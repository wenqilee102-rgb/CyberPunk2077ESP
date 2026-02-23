using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatPoolModifierRuntimeData : CVariable
	{
		private gameStatPoolModifier _modifier;
		private CFloat _modificationDelay;
		private CBool _inRange;
		private TweakDBID _recordID;

		[Ordinal(0)] 
		[RED("modifier")] 
		public gameStatPoolModifier Modifier
		{
			get => GetProperty(ref _modifier);
			set => SetProperty(ref _modifier, value);
		}

		[Ordinal(1)] 
		[RED("modificationDelay")] 
		public CFloat ModificationDelay
		{
			get => GetProperty(ref _modificationDelay);
			set => SetProperty(ref _modificationDelay, value);
		}

		[Ordinal(2)] 
		[RED("inRange")] 
		public CBool InRange
		{
			get => GetProperty(ref _inRange);
			set => SetProperty(ref _inRange, value);
		}

		[Ordinal(3)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		public gameStatPoolModifierRuntimeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
