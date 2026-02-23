using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckQuestFact : AIbehaviorconditionScript
	{
		private CName _questFactName;
		private CInt32 _comparedValue;
		private CEnum<ECompareOp> _comparator;

		[Ordinal(0)] 
		[RED("questFactName")] 
		public CName QuestFactName
		{
			get => GetProperty(ref _questFactName);
			set => SetProperty(ref _questFactName, value);
		}

		[Ordinal(1)] 
		[RED("comparedValue")] 
		public CInt32 ComparedValue
		{
			get => GetProperty(ref _comparedValue);
			set => SetProperty(ref _comparedValue, value);
		}

		[Ordinal(2)] 
		[RED("comparator")] 
		public CEnum<ECompareOp> Comparator
		{
			get => GetProperty(ref _comparator);
			set => SetProperty(ref _comparator, value);
		}

		public CheckQuestFact(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
