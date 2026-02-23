using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiExternalPhoneElement : gameuiLocalPhoneElement
	{
		private rRef<inkWidgetLibraryResource> _libraryResource;

		[Ordinal(6)] 
		[RED("libraryResource")] 
		public rRef<inkWidgetLibraryResource> LibraryResource
		{
			get => GetProperty(ref _libraryResource);
			set => SetProperty(ref _libraryResource, value);
		}

		public gameuiExternalPhoneElement(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
