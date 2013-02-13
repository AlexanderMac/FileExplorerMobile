//
//  ObjNavigationVC.cs
//
//  Author:
//       Alexander Matsibarov (macasun) <amatsibarov@gmail.com>
//
//  Copyright (c) 2013 Alexander Matsibarov
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FileExplorerMobile.mTouch.Views
{
	public class FileEntryNavigationVC : UINavigationController
	{
		#region Initialization
		public FileEntryNavigationVC() : base(null, bundle: null)
		{
			TabBarItem.Title = "Explorer";
			TabBarItem.Image = UIImage.FromBundle("Content/Images/TabBar/explorer32.png");
		}
		#endregion

		#region UI Logic
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			NavigationBar.BarStyle = UIBarStyle.Black;
			PushViewController(new FileEntryTableVC(null), false);
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}
		#endregion
	}
}

