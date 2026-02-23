using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVisualTagToFoleyLoopMetadata : CVariable
	{
		private CArray<CName> _visualtags;
		private audioFoleyLoopMetadata _loop;

		[Ordinal(0)] 
		[RED("visualtags")] 
		public CArray<CName> Visualtags
		{
			get => GetProperty(ref _visualtags);
			set => SetProperty(ref _visualtags, value);
		}

		[Ordinal(1)] 
		[RED("loop")] 
		public audioFoleyLoopMetadata Loop
		{
			get => GetProperty(ref _loop);
			set => SetProperty(ref _loop, value);
		}

		public audioVisualTagToFoleyLoopMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
