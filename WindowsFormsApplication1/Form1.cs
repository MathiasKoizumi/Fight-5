using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApplication1
{
	public class Form1 : Form
	{
		private IContainer components;

		private Jingo bob = new Jingo();

		public Form1 formular;

		private Jongo trælle = new Jongo();

		private WindowsMediaPlayer wplayer = (WindowsMediaPlayer)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));

		private Random time = new Random();

		private int ibli = 200;

		private int abli = 300;

		private int cula = 600;

		private string currentMp3 = "Math.mp3";

		private int cola;

		private Panel panel1;

		private Button button1;

		private BolleHeaven kukur = new BolleHeaven();

		private List<Afmagt> bollemælk;

		private Random junkie = new Random();

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(WindowsFormsApplication1.Form1));
			panel1 = new System.Windows.Forms.Panel();
			button1 = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.AutoSize = true;
			panel1.Controls.Add(button1);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(923, 694);
			panel1.TabIndex = 1;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			button1.BackColor = System.Drawing.Color.Transparent;
			button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			button1.Font = new System.Drawing.Font("Segoe Print", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button1.Image = (System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
			button1.Location = new System.Drawing.Point(292, 436);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(251, 42);
			button1.TabIndex = 2;
			button1.Text = "T\u00b4-i\u00b4m- i\u00b4s s\u00b4o-";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(bongo);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSize = true;
			base.ClientSize = new System.Drawing.Size(955, 710);
			base.Controls.Add(panel1);
			Cursor = System.Windows.Forms.Cursors.Arrow;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Form1";
			Text = "Ole\u00b4ir";
			base.Activated += new System.EventHandler(Loadup);
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormClosingMeDown);
			base.Load += new System.EventHandler(Form_loadme);
			panel1.ResumeLayout(performLayout: false);
			ResumeLayout(performLayout: false);
			PerformLayout();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			panel1_Paint(0, e);
			base.OnPaint(e);
		}

		public void newJongo()
		{
			trælle = new Jongo();
		}

		public void playMP3()
		{
			string[] array = new string[8]
			{
				"WhiteRiver.mp3",
				"Binkelstein.mp3",
				"clone2.mp3",
				"Sirius Extinct.mp3",
				"bubba.mp3",
				"NewEnd.mp3",
				"EveningSun2.mp3",
				"Mushroom.mp3"
			};
			using (Stream input = GetType().Assembly.GetManifestResourceStream("WindowsFormsApplication1.Resources." + array[new Random().Next(8)]))
			{
				if (!File.Exists("Math.mp3"))
				{
					using (Stream output = File.Create("Math.mp3"))
					{
						CopyStream(input, output);
					}
				}
			}
			if (wplayer.playState != WMPPlayState.wmppsPlaying)
			{
				wplayer.URL = "Math.mp3";
				wplayer.controls.play();
			}
		}

		public static void CopyStream(Stream input, Stream output)
		{
			byte[] array = new byte[8192];
			int count;
			while ((count = input.Read(array, 0, array.Length)) > 0)
			{
				output.Write(array, 0, count);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		public void timetoJongoisme()
		{
			for (int i = 0; i < trælle.getJohn().Count; i++)
			{
				Point[] waypoints = trælle.getJohn()[i].getWaypoints();
				for (int j = 0; j < waypoints.Length; j++)
				{
					waypoints[j].X = waypoints[j].X + 1;
					waypoints[j].Y = waypoints[j].Y + 200;
				}
				trælle.getJohn()[i].changeCourse();
			}
		}

		public void jongoTime()
		{
			Graphics graphics = panel1.CreateGraphics();
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.buddy.png");
			Image image = Image.FromStream(manifestResourceStream);
			manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.world.png");
			Image image2 = Image.FromStream(manifestResourceStream);
			string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
			string[] array = manifestResourceNames;
			foreach (string value in array)
			{
				Console.WriteLine(value);
			}
			BolleHeaven bolleHeaven = new BolleHeaven();
			for (int num = 15; num >= 0; num--)
			{
				if (cula < 4)
				{
					cula = 600;
				}
				cula--;
				for (int num2 = trælle.getJohn().Count - 1; num2 > 0; num2--)
				{
					if (ibli < 3)
					{
						ibli = 80;
					}
					else
					{
						ibli -= 2;
					}
					if (abli < 3)
					{
						abli = 60;
					}
					else
					{
						abli -= 2;
					}
					trælle.getJohn()[num2].changeCourse();
					trælle.getJohn()[num2].moodChange(trælle.getJohn()[num2].changeCourse(), new Juklas());
					timetoJongoisme();
					switch (time.Next(5))
					{
					case 0:
						graphics.FillEllipse(new SolidBrush(trælle.getJohn()[num2].changeCourse().getColor()), new Rectangle(trælle.getJohn()[num2].getPoint(), trælle.getJohn()[num2].getSize()));
						break;
					case 1:
						for (int num3 = 100; num3 >= 0; num3--)
						{
							Random random = new Random();
							graphics.FillClosedCurve(new SolidBrush(Color.FromArgb(random.Next(150), random.Next(25) + 200, random.Next(15) + 200, random.Next(40) + 215)), createPoints(3));
						}
						break;
					case 2:
						for (int num4 = 40; num4 >= 0; num4--)
						{
							Point[] points = createPoints(4, 0);
							graphics.FillPolygon(new SolidBrush(Color.FromArgb(new Random().Next(180), new Random().Next(40) + 200, new Random().Next(40) + 200, new Random().Next(55) + 200)), points);
						}
						break;
					case 3:
						graphics.DrawBeziers(new Pen(Color.White, 3f), createPoints(205, 300));
						graphics.DrawBeziers(new Pen(Color.White, 3f), createPoints(205, -200));
						graphics.DrawBeziers(new Pen(Color.White, 3f), createPoints(205, 20));
						graphics.DrawBeziers(new Pen(Color.White, 3f), createPoints(205, 100));
						break;
					case 4:
						if (junkie.Next(cula) == 0)
						{
							graphics.DrawString(bolleHeaven.gEn2Name(245, junkie), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(400) + 10, junkie.Next(490) + 10));
						}
						if (junkie.Next(800) == 0)
						{
							graphics.DrawString("F\u00b4un \u00b4a zar-", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(350f, 20f));
							cola = 1;
						}
						if (junkie.Next(400) == 0)
						{
							graphics.DrawString(bolleHeaven.gEn2Name(245, junkie), new Font("Segoe Script", 72f, FontStyle.Bold), new LinearGradientBrush(new Point(0, 0), new Point(600, 600), Color.White, Color.DarkSlateGray), new PointF(250 - junkie.Next(230), 400 - junkie.Next(200)));
						}
						break;
					}
				}
				if (junkie.Next(abli) == 0)
				{
					graphics.DrawImage(image2, new Point(200, 50));
				}
				if (junkie.Next(ibli) == 0)
				{
					graphics.DrawImage(image, new Point(600, 350));
				}
			}
		}

		private Point[] createPoints(int p, int p_2)
		{
			Point[] array = new Point[p];
			for (int num = p - 1; num >= 0; num--)
			{
				array[num] = new Point(new Random().Next(530) + p_2, new Random().Next(630) - p_2);
			}
			return array;
		}

		private Point[] createPoints(int k)
		{
			Point[] array = new Point[k];
			for (int num = k - 1; num >= 0; num--)
			{
				array[num] = new Point(new Random().Next(630) + 200, new Random().Next(350) + 150);
			}
			modifyPoints(array);
			return array;
		}

		public void modifyPoints(Point[] j)
		{
			for (int num = j.Length - 1; num >= 0; num--)
			{
				double num2 = Math.Sin(new Random().Next(500));
				if (num2 == 0.0)
				{
					num2 = 1.0;
				}
				j[num].X = j[num].X * (int)(Math.Sin(new Random().Next(500)) / num2);
			}
		}

		public Form1 sendForm()
		{
			return this;
		}

		private int patrol()
		{
			throw new NotImplementedException();
		}

		public Form1()
		{
			InitializeComponent();
			fillJoin();
		}

		public void moveLabel(Label lal, Random kf)
		{
			Point point2 = lal.Location = new Point(kf.Next(200) + 610, kf.Next(140));
		}

		public void avoidCollisionLabel(Label l, Label j)
		{
			if (l.Location.Y > j.Location.Y && l.Location.Y - j.Location.Y < 30)
			{
				moveLabel(j, junkie);
				avoidCollisionLabel(l, j);
			}
			if (l.Location.Y < j.Location.Y && j.Location.Y - l.Location.Y < 30)
			{
				moveLabel(j, junkie);
				avoidCollisionLabel(l, j);
			}
		}

		private void bongo(object sender, EventArgs e)
		{
			playMP3();
			switch (new Random().Next(28))
			{
			case 0:
				button1.Text = "F4\u00b4 zi-h\u00b4 neu-n";
				break;
			case 1:
				button1.Text = "Jon\u00b4gus Brae-ch\u00b4us";
				fillJoin();
				break;
			case 2:
				button1.Text = kukur.gEn2Name(200, junkie);
				break;
			case 3:
				button1.Text = "Combat f-yr\u00b4";
				break;
			case 4:
				button1.Text = "Spra\u00b4ch me\u00b4";
				break;
			case 5:
				button1.Text = "Før-\u00b4e li\u00b4d\u00b4";
				break;
			case 6:
				button1.Text = "so-bi-\u00b4 n\u00b4ow-";
				break;
			case 7:
				button1.Text = "Fu-n\u00b44";
				break;
			case 8:
				button1.Text = "-4\u00b4";
				break;
			case 9:
				button1.Text = "Jonga Banan\u00b4";
				break;
			case 10:
				button1.Text = "f-4zehn";
				break;
			case 11:
				button1.Text = "O\u00b4lej-ma\u00b4";
				break;
			case 12:
				button1.Text = "\u00b4ra\u00b4chi-us-";
				break;
			case 13:
				button1.Text = "H\u00b4ep-n4\u00b4 fu-n\u00b4i";
				break;
			case 14:
				button1.Text = "Go-wal\u00b4ski\u00b4-";
				break;
			case 15:
				button1.Text = "P-rak\u00b4ish";
				break;
			case 16:
				button1.Text = "Le-go-";
				break;
			case 17:
				button1.Text = "Sa-yo-nara-";
				break;
			case 18:
				button1.Text = "\u00b4is mi- i- ø'ret de- sjov\u00b4";
				break;
			case 19:
				button1.Text = "\u00b4ro-ja";
				break;
			case 20:
				button1.Text = "|\u00b4na-do";
				break;
			case 21:
				button1.Text = "Yg\u00b4dra-\u00b4sil";
				break;
			case 22:
				button1.Text = "Sa-tyr\u00b4";
				break;
			case 23:
				button1.Text = "\u00b4ov be\u00b4n";
				break;
			case 24:
				button1.Text = "Vi-go";
				break;
			case 25:
				button1.Text = "M\u00b4ed lemn";
				break;
			case 26:
				button1.Text = kukur.gEn2Name(200, junkie);
				break;
			case 27:
				button1.Text = kukur.gEn2Name(200, junkie);
				break;
			default:
				button1.Text = "Dummy!!!";
				break;
			}
			for (int num = 7; num > 0; num--)
			{
				fillJoin();
				jongoTime();
			}
		}

		private void fillJoin()
		{
			if (new Jingo().showBirth().Second > 4)
			{
				new Movement().joinForce();
			}
			else
			{
				new BolleHeaven().bolledej(0, 4);
			}
		}

		public void fillArrayBollemælk()
		{
			Jingo jingo = new Jingo();
			jingo.showBirth();
			jingo.jingoTime(tidspres());
			jingo.timesTwenty(DateTime.Now);
		}

		private Juklas tidspres()
		{
			throw new NotImplementedException();
		}

		private void Form_loadme(object sender, EventArgs e)
		{
			playMP3();
			jongoTime();
			button1.PerformClick();
		}

		private void FormClosingMeDown(object sender, FormClosingEventArgs e)
		{
			TryToDelete("Math.mp3");
		}

		private static bool TryToDelete(string f)
		{
			try
			{
				File.Delete(f);
				return true;
			}
			catch (IOException)
			{
				return false;
			}
		}

		private void Loadup(object sender, EventArgs e)
		{
		}
	}
}
