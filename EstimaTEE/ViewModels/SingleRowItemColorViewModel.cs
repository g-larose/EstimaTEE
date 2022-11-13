using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimaTEE.ViewModels
{
    public class SingleRowItemColorViewModel : ViewModelBase
    {
		private Color _rectangleColor;
		public Color RectangleColor
		{
			get => _rectangleColor;
			set => OnPropertyChanged(ref _rectangleColor, value);
		}

		private string _colorName;
		public string ColorName
		{
			get => _colorName;
			set => OnPropertyChanged(ref _colorName, value);
		}

        public SingleRowItemColorViewModel()
        {
        }
    }
}
