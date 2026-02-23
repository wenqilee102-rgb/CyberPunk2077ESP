using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDebugSystemData : inkILayerSystemData
	{
		private CArray<inkDebugLayerEntry> _entries;
		private rRef<inkWidgetLibraryResource> _rootLibrary;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<inkDebugLayerEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(1)] 
		[RED("rootLibrary")] 
		public rRef<inkWidgetLibraryResource> RootLibrary
		{
			get => GetProperty(ref _rootLibrary);
			set => SetProperty(ref _rootLibrary, value);
		}

		public inkDebugSystemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
