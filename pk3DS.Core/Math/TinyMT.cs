/*
* Originally written in JS: https://github.com/zaksabeast/TinyMTjs
* Translated to C# by Axyn
* 
* LICENSE:
* Copyright (c) 2011, 2013 Mutsuo Saito, Makoto Matsumoto,
  Hiroshima University and The University of Tokyo.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without
  modification, are permitted provided that the following conditions are
  met:
      * Redistributions of source code must retain the above copyright
          notice, this list of conditions and the following disclaimer.
      * Redistributions in binary form must reproduce the above
          copyright notice, this list of conditions and the following
          disclaimer in the documentation and/or other materials provided
          with the distribution.
      * Neither the name of the Hiroshima University nor the names of
          its contributors may be used to endorse or promote products
          derived from this software without specific prior written
          permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
  "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
  LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
  A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
  OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
  SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
  LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
  DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
  THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
  (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
  OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

namespace TinyMT;

public class TinyMT32
{
    private const uint MAT1_DEFAULT_32 = 0x8F7011EE;
    private const uint MAT2_DEFAULT_32 = 0xFC78FF1F;
    private const uint TMAT_DEFAULT_32 = 0x3793FDFF;

    private const int TINYMT32_MASK = 0x7FFFFFFF;
    private const int TINYMT32_SH0 = 1;
    private const int TINYMT32_SH1 = 10;
    private const int TINYMT32_SH8 = 8;
    private const int MIN_LOOP = 8;
    private const int PRE_LOOP = 8;

    private readonly uint mat1;
    private readonly uint mat2;
    private readonly uint tMat;

    private uint[] status = new uint[4];

    public TinyMT32(uint seed, uint mat1 = MAT1_DEFAULT_32, uint mat2 = MAT2_DEFAULT_32, uint tMat = TMAT_DEFAULT_32)
    {
        this.mat1 = mat1;
        this.mat2 = mat2;
        this.tMat = tMat;

        Init(seed);
    }

    private void Init(uint seed)
    {
        status = [seed, mat1, mat2, tMat];

        for (int i = 1; i < MIN_LOOP;  i++)
        {
            int s = (int)(status[(i - 1) & 3] ^ (status[(i - 1) & 3] >>> 30));
            status[i & 3] ^= (uint)((((s >>> 16) * 0x6C078965) << 16) + (s & 0xFFFF) * 0x6C078965 + i);
        }

        PeriodCertification();

        for (int i = 0; i < PRE_LOOP; i++)
        {
            NextState();
        }
    }

    private void PeriodCertification()
    {
        if (status[0] == TINYMT32_MASK && status[1] == 0 && status[2] == 0 && status[3] == 0)
            status = [TINYMT32_MASK, TINYMT32_MASK, TINYMT32_MASK, TINYMT32_MASK];
    }

    private void NextState()
    {
        //uint y = status[3];
        int x = (int)((status[0] & TINYMT32_MASK) ^ status[1] ^ status[2]);
        int y;

        x ^= x << TINYMT32_SH0;
        y = (int)(status[3] ^ ((status[3] >>> TINYMT32_SH0) ^ x));

        status[0] = status[1];
        status[1] = status[2];
        status[2] = (uint)(x ^ (y << TINYMT32_SH1));
        status[3] = (uint)y;

        if ((y & 1) == 1)
        {
            status[1] ^= mat1;
            status[2] ^= mat2;
        }
    }

    private uint Temper()
    {
        uint t0 = status[3];
        uint t1 = status[0] + (status[2] >>> TINYMT32_SH8);

        int t0_int = (int)(t0 ^ t1);

        if ((t1 & 1) == 1)
        {
            t0_int = (int)(t0_int ^ tMat);
        }

        return (uint)(t0_int);
    }

    public void Reseed(uint seed)
    {
        Init(seed);
    }

    public uint GetNextUInt32()
    {
        NextState();
        return Temper();
    }
}