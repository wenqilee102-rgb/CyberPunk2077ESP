using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClothingSetIconsPopup : gameuiWidgetGameController
	{
		private inkWidgetReference _iconGrid;
		private inkWidgetReference _buttonHintsRoot;
		private CHandle<ClothingSetIconsPopupData> _data;
		private inkWidgetLibraryReference _libraryPath;

		[Ordinal(2)] 
		[RED("iconGrid")] 
		public inkWidgetReference IconGrid
		{
			get => GetProperty(ref _iconGrid);
			set => SetProperty(ref _iconGrid, value);
		}

		[Ordinal(3)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get => GetProperty(ref _buttonHintsRoot);
			set => SetProperty(ref _buttonHintsRoot, value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<ClothingSetIconsPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(5)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetProperty(ref _libraryPath);
			set => SetProperty(ref _libraryPath, value);
		}

		public ClothingSetIconsPopup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
