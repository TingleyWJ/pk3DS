using pk3DS.Core;
using pk3DS.Core.Structures.Gen6;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pk3DS.WinForms;

public partial class NatureViewer : Form
{
    const int ROWS = 17; //Header row + 8 perfect possible IV combos: [31, 63, 95, 127, 159, 191, 223, 255]
    const int NON_HEADER_ROWS = ROWS - 1;

    private static int NextTabIndex = 0;

    private readonly string[] SpeciesList = Main.Config.GetText(TextName.SpeciesNames);

    private int TotalCols { get; set; }

    private int Species { get; set; }
    private int Level { get; set; }
    private int TRClass { get; set; }

    #region Components
    private Label PokemonLabel, PokemonLabelName;
    private TableLayoutPanel MainTableLayoutPanel;
    private List<Label> IVLabels, IVHeaderLabels;
    private List<TextBox> IVTextBoxes;
    #endregion

    public NatureViewer(int totalCols, int species, int level, int tr_class)
    {
        TotalCols = totalCols;

        Species = species;
        Level = level;
        TRClass = tr_class;

        InitComponents();
    }

    private void InitComponents()
    {
        PokemonLabel = new();
        PokemonLabelName = new();
        MainTableLayoutPanel = new();
        IVHeaderLabels = [];
        IVLabels = [];
        IVTextBoxes = [];

        for (int i = 0; i < TotalCols; i++)
            IVHeaderLabels.Add(new());

        for (int i = 0; i < TotalCols * (NON_HEADER_ROWS / 2); i++)
        {
            IVLabels.Add(new());
            IVTextBoxes.Add(new());
        }

        MainTableLayoutPanel.SuspendLayout();
        SuspendLayout();

        PokemonLabel.Name = "PokemonLabel";
        PokemonLabel.Text = "Nature Breakdown for:";
        PokemonLabel.Location = new System.Drawing.Point(5, 5);
        PokemonLabel.AutoSize = true;

        PokemonLabelName.Name = "PokemonLabelName";
        PokemonLabelName.Text = $"{SpeciesList[Species]}";
        PokemonLabelName.AutoSize = true;
        PokemonLabelName.Font = new System.Drawing.Font(DefaultFont, System.Drawing.FontStyle.Bold);

        MainTableLayoutPanel.Name = "MainTableLayoutPanel";
        MainTableLayoutPanel.ColumnCount = TotalCols;
        MainTableLayoutPanel.RowCount = ROWS;
        MainTableLayoutPanel.Size = new System.Drawing.Size(TotalCols * 140, ROWS * 30);
        MainTableLayoutPanel.Location = new System.Drawing.Point(5, 5 + PokemonLabel.Size.Height);
        MainTableLayoutPanel.TabIndex = NextTabIndex++;
        MainTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

        float colPercent = 100f / TotalCols;
        float rowPercent = 100f / NON_HEADER_ROWS;

        for (int i = 0; i < TotalCols; i++)
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, colPercent));

        MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
        for (int i = 0; i < NON_HEADER_ROWS; i++)
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, rowPercent));

        for (int i = 0; i < TotalCols; i++)
            MainTableLayoutPanel.Controls.Add(IVHeaderLabels[i], i, 0);

        for (int i = 1, labelIndex = 0, textBoxIndex = 0; i <= NON_HEADER_ROWS; i++)
            for (int j = 0; j < TotalCols; j++)
            {
                if (i % 2 == 1)
                    MainTableLayoutPanel.Controls.Add(IVLabels[labelIndex++], j, i);
                else
                    MainTableLayoutPanel.Controls.Add(IVTextBoxes[textBoxIndex++], j, i);
            }

        for (int i = 0; i < IVHeaderLabels.Count; i++)
        {
            Label IVHeaderLabel = IVHeaderLabels[i];

            IVHeaderLabel.Name = "HeaderLabel_" + i;
            IVHeaderLabel.Text = $"{(i == 0 ? "Perfect " : "")}{31 - i} IVs";

            IVHeaderLabel.AutoSize = true;
            IVHeaderLabel.Dock = DockStyle.Fill;
            //IVHeaderLabel.Location = new System.Drawing.Point(143, 0);
            //IVHeaderLabel.Size = new System.Drawing.Size(134, 50);
            IVHeaderLabel.TabIndex = NextTabIndex++;
            IVHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        for (int i = 0; i < IVLabels.Count; i++)
        {
            Label IVLabel = IVLabels[i];

            int currCol = i % TotalCols;
            int currRow = i / TotalCols;
            int perfIVs = 31 + 32 * currRow;
            int currIV = perfIVs - currCol;

            IVLabel.Name = "Label_" + i;
            IVLabel.Text = $"Set IV to {currIV}";

            IVLabel.AutoSize = true;
            IVLabel.Dock = DockStyle.Fill;
            //IVLabel.Location = new System.Drawing.Point(143, 0);
            //IVLabel.Size = new System.Drawing.Size(134, 50);
            IVLabel.TabIndex = NextTabIndex++;
            IVLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        for (int i = 0; i < IVTextBoxes.Count; i++)
        {
            TextBox IVTextBox = IVTextBoxes[i];

            int currCol = i % TotalCols;
            int currRow = i / TotalCols;
            int perfIVs = 31 + 32 * currRow;
            int currIV = perfIVs - currCol;

            IVTextBox.Name = "TextBox_" + i;
            IVTextBox.ReadOnly = true;
            //IVTextBox.Location = new System.Drawing.Point(3, 81);
            IVTextBox.Size = new System.Drawing.Size(134, 23);
            IVTextBox.TabIndex = NextTabIndex++;
            IVTextBox.TabStop = false;

            uint nature = NatureCalculation.GetNature(Species, Level, currIV, TRClass);
            IVTextBox.Text = NatureCalculation.GetNatureString(nature);
            IVTextBox.BackColor = NatureCalculation.GetNatureColor(nature);
        }

        Name = "NatureViewer";
        Text = "Nature Viewer";
        Size = new System.Drawing.Size(MainTableLayoutPanel.Size.Width + 25, PokemonLabel.Size.Height + MainTableLayoutPanel.Size.Height + 50);
        FormBorderStyle = FormBorderStyle.FixedSingle;

        Controls.Add(PokemonLabel);

        PokemonLabelName.Location = new System.Drawing.Point(2 + PokemonLabel.Size.Width, 5);
        Controls.Add(PokemonLabelName);
            
        Controls.Add(MainTableLayoutPanel);

        MainTableLayoutPanel.ResumeLayout(true);
        ResumeLayout(false);
    }

    public void Reload(int species, int level, int tr_class)
    {
        if (species != Species)
            PokemonLabelName.Text = $"{SpeciesList[species]}";

        Species = species;
        Level = level;
        TRClass = tr_class;

        for (int i = 0; i < IVTextBoxes.Count; i++)
        {
            TextBox IVTextBox = IVTextBoxes[i];

            int currCol = i % TotalCols;
            int currRow = i / TotalCols;
            int perfIVs = 31 + 32 * currRow;
            int currIV = perfIVs - currCol;

            uint nature = NatureCalculation.GetNature(Species, Level, currIV, TRClass);
            IVTextBox.Text = NatureCalculation.GetNatureString(nature);
            IVTextBox.BackColor = NatureCalculation.GetNatureColor(nature);
        }

    }
}
