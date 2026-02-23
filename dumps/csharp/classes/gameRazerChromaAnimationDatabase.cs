using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRazerChromaAnimationDatabase : CResource
	{
		private CArray<gameRazerChromaAnimationSet> _setsSerialized;

		[Ordinal(1)] 
		[RED("setsSerialized")] 
		public CArray<gameRazerChromaAnimationSet> SetsSerialized
		{
			get => GetProperty(ref _setsSerialized);
			set => SetProperty(ref _setsSerialized, value);
		}

		public gameRazerChromaAnimationDatabase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
