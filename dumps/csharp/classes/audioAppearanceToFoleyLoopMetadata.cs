using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAppearanceToFoleyLoopMetadata : CVariable
	{
		private CArray<CName> _appearances;
		private audioFoleyLoopMetadata _loop;

		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(1)] 
		[RED("loop")] 
		public audioFoleyLoopMetadata Loop
		{
			get => GetProperty(ref _loop);
			set => SetProperty(ref _loop, value);
		}

		public audioAppearanceToFoleyLoopMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
