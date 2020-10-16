using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game_001
{
    //*****************************************************************//
    //*********************     Push Push 게임    *********************//
    //*****************************************************************//

    public partial class Form1 : Form
    {
        const int WTileSize = 16;
        const int HTileSize = 9;
        const string Title = "★★★ PushPush ★★★";

        int Stage;
        int KeyCount;
        bool EndGame;

        Image Human;
        Image HumanF;
        Image HumanB;
        Image HumanL;
        Image HumanR;
        Image Wall;
        Image Road;
        Image Box;
        Image Dot;

        int WTile;
        int HTile;
        int XHuman;
        int YHuman;
        int XHumanOld;
        int YHumanOld;

        char[][]  MapReal; //MapReal : 게임이 돌고 있는 맵

        string[,] Map = {
                                        // Stage1
                                        {        "################", // 0
                                                 "######      ####", // 1
                                                 "##. @ B     ####", // 2
                                                 "######   B .####", // 3
                                                 "##. #### B  ####", // 4
                                                 "##  ##   .  ####", // 5
                                                 "##B  .  BBB .###", // 6
                                                 "##       .   ###", // 7
                                                 "################"  // 8
                                        },
                                        // Stage 2
                                        {
                                                 "################",
                                                 "####       #####",
                                                 "#### B####    ##",
                                                 "##    ####    ##",
                                                 "##  @   B   B###",
                                                 "##   ..##  B ###",
                                                 "#### ..##    ###",
                                                 "################",
                                                 "################"
                                        },
                                        // Stage 3
                                        {
                                                 "################",
                                                 "###    #########",
                                                 "###  B ###   ###",
                                                 "##    B      ###",
                                                 "## # ##  ###  .#",
                                                 "## # ##  @B  ..#",
                                                 "##  B         .#",
                                                 "################",
                                                 "################"
                                        },
                                        // Stage 4
                                        {
                                                 "################",
                                                 "#####    #######",
                                                 "#####B B #######",
                                                 "###   ## #######",
                                                 "#   # ## # B..##",
                                                 "# B   B  @ B..##",
                                                 "# ### # ##  ..##",
                                                 "#####    #######",
                                                 "################"
                                        },
                                        // Stage 5
                                        {
                                                 "################",
                                                 "##..  #     ####",
                                                 "##..  # B  B  ##",
                                                 "##..  #B####  ##",
                                                 "##..    @ ##  ##",
                                                 "##    # #  B ###",
                                                 "#### B  B B B ##",
                                                 "####    #     ##",
                                                 "################"
                                        },
                                        // Stage 6
                                        {
                                                "################",
                                                "######     @####",
                                                "###### B#B #####",
                                                "###     B  #####",
                                                "###  ##  B #####",
                                                "#      B # #####",
                                                "#....  ## B   ##",
                                                "##...       B ##",
                                                "################"
                                        }

                        };

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
        }

        public Form1()
        {
            InitializeComponent();

            Stage = 0;

            HumanF = new Bitmap(Properties.Resources.HumanF);
            WTile = HumanF.Width;
            HTile = HumanF.Height;
            ClientSize = new Size(WTileSize * WTile, HTileSize * HTile);
            HumanB = new Bitmap(Properties.Resources.HumanB);
            HumanL = new Bitmap(Properties.Resources.HumanL);
            HumanR = new Bitmap(Properties.Resources.HumanR);
            Wall = new Bitmap(Properties.Resources.Wall);
            Road = new Bitmap(Properties.Resources.Road);
            Box = new Bitmap(Properties.Resources.Box);
            Dot = new Bitmap(Properties.Resources.Dot);

            XHuman = 0;
            YHuman = 0;

            LoadMap(); 
        }

        private void LoadMap() // 다음판을 맵에 띄울때 사용
        {
            MapReal = new char[HTileSize][];
            for (int i = 0; i < HTileSize; ++i)
            {
                MapReal[i] = Map[Stage, i].ToCharArray();  //string T = "test";
                                                           //char[] CT = new char[]{'t'. 'e', 's', 't'} == 이거대신 ToCharArray를 사용
                                                           //char[] CT = T.ToCharArray(); // test 를 조각내줌
            }
            KeyCount = 0;
            Human = HumanF;
        }

        private void Form1_Paint(object sender, PaintEventArgs e) // 맵에 그리는곳
        {
            EndGame = true;
            Image Temp = Wall;
            for (int j = 0; j < HTileSize; ++j)
            {
                for (int i = 0; i < WTileSize; ++i)
                {
                    switch (MapReal[j][i])
                    {
                        case '#':
                            Temp = Wall;
                            break;
                        case 'B':
                            Temp = Box;
                            if (Map[Stage, j][i] != '.')
                            {
                                EndGame = false;
                            }
                            break;
                        case '.':
                            Temp = Dot;
                            break;
                        case ' ':
                            Temp = Road;
                            break;
                        case '@':
                            Temp = Human;
                            XHuman = i;
                            YHuman = j;
                            break;
                    }
                    e.Graphics.DrawImage(Temp, WTile * i, HTile * j);
                }
            }
            Text = Title + 
                   "                     " + 
                   "Stage : [ " +  (Stage + 1) +" ]" +
                   "          " +
                   "Move Times : " +
                   "[ " + KeyCount + " ]" +
                   "                     " +
                   "Refresh : [ F5 ]"; 
        }

        private void Move()
        {

            if (MapReal[YHuman][XHuman] == '#')
            {
                return;
            }

            if (MapReal[YHuman][XHuman] == 'B')
            {
                if (MapReal[YHuman * 2 - YHumanOld][XHuman * 2 - XHumanOld] == '#')
                {
                    return;
                }
                if (MapReal[YHuman * 2 - YHumanOld][XHuman * 2 - XHumanOld] == 'B')
                {
                    return;
                }
                MapReal[YHuman*2 - YHumanOld][XHuman*2 - XHumanOld] = 'B';    
            }
            if (Map[Stage, YHumanOld][XHumanOld] == '.')
            {
                MapReal[YHumanOld][XHumanOld] = '.';
            }
            else
            {
                MapReal[YHumanOld][XHumanOld] = ' ';
            }
            MapReal[YHuman][XHuman] = '@';
            ++KeyCount;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            YHumanOld = YHuman;
            XHumanOld = XHuman ;
            switch (e.KeyCode)
            {
                case Keys.F5:
                    if (DialogResult.Yes == MessageBox.Show("Do you want Refresh?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        LoadMap();
                        Refresh();
                    }
                    return;
                case Keys.Left:
                    --XHuman;
                    Human = HumanL;
                    break;
                case Keys.Right:
                    ++XHuman;
                    Human = HumanR;
                    break;
                case Keys.Up:
                    --YHuman;
                    Human = HumanB;
                    break;
                case Keys.Down:
                    ++YHuman;
                    Human = HumanF;
                    break;
                default:
                    return;
            }

            Move();
            Refresh();

            if (EndGame == true)
            { 
                ++Stage;

                if (Stage == (Map.Length / HTileSize))
                {
                    MessageBox.Show(" Congratulation !! ♥.♥ ", "★★★ Game Clear ★★★", MessageBoxButtons.OK);
                    Environment.Exit(0);
                }

                MessageBox.Show("Good !!  Let's Go, Next Stage!", "★★★ STAGE CLEAR ★★★", MessageBoxButtons.OK);
                LoadMap();
                Refresh();
            }
        }
    }
}
