using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsSetAnimsetWeight : scnSceneEvent
	{
		private scnActorId _actorId;
		private CName _animsetName;
		private CFloat _weight;

		[Ordinal(6)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetProperty(ref _actorId);
			set => SetProperty(ref _actorId, value);
		}

		[Ordinal(7)] 
		[RED("animsetName")] 
		public CName AnimsetName
		{
			get => GetProperty(ref _animsetName);
			set => SetProperty(ref _animsetName, value);
		}

		[Ordinal(8)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		public scneventsSetAnimsetWeight(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
