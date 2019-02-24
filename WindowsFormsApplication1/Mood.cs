using System;
using System.Drawing;

namespace WindowsFormsApplication1
{
	internal class Mood
	{
		private Color currentMood;

		public Color getMood()
		{
			return currentMood;
		}

		public Color returnMood()
		{
			return currentMood;
		}

		public Juklas affectMood(int damn, Juklas food)
		{
			currentMood = Color.FromArgb(20, 240, 180, 240);
			if (currentMood.B + currentMood.R < new Random().Next(280))
			{
				currentMood = Color.White;
			}
			return food;
		}

		internal Mood roundUp()
		{
			currentMood = Color.FromArgb(currentMood.ToArgb() + 200);
			return new Mood();
		}

		internal Mood affectMood(int p)
		{
			throw new NotImplementedException();
		}
	}
}
