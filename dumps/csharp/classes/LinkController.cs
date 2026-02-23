using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LinkController : inkButtonController
	{
		private CString _linkAddress;
		private HDRColor _defaultColor;
		private HDRColor _hoverColor;
		private HDRColor _iGNORED_COLOR;

		[Ordinal(13)] 
		[RED("linkAddress")] 
		public CString LinkAddress
		{
			get => GetProperty(ref _linkAddress);
			set => SetProperty(ref _linkAddress, value);
		}

		[Ordinal(14)] 
		[RED("defaultColor")] 
		public HDRColor DefaultColor
		{
			get => GetProperty(ref _defaultColor);
			set => SetProperty(ref _defaultColor, value);
		}

		[Ordinal(15)] 
		[RED("hoverColor")] 
		public HDRColor HoverColor
		{
			get => GetProperty(ref _hoverColor);
			set => SetProperty(ref _hoverColor, value);
		}

		[Ordinal(16)] 
		[RED("IGNORED_COLOR")] 
		public HDRColor IGNORED_COLOR
		{
			get => GetProperty(ref _iGNORED_COLOR);
			set => SetProperty(ref _iGNORED_COLOR, value);
		}

		public LinkController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
