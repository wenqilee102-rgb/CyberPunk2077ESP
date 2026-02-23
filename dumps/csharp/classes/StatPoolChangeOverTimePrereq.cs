using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolChangeOverTimePrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CFloat _timeFrame;
		private CFloat _valueToCheck;
		private CBool _comparePercentage;
		private CBool _checkGain;

		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(1)] 
		[RED("timeFrame")] 
		public CFloat TimeFrame
		{
			get => GetProperty(ref _timeFrame);
			set => SetProperty(ref _timeFrame, value);
		}

		[Ordinal(2)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get => GetProperty(ref _valueToCheck);
			set => SetProperty(ref _valueToCheck, value);
		}

		[Ordinal(3)] 
		[RED("comparePercentage")] 
		public CBool ComparePercentage
		{
			get => GetProperty(ref _comparePercentage);
			set => SetProperty(ref _comparePercentage, value);
		}

		[Ordinal(4)] 
		[RED("checkGain")] 
		public CBool CheckGain
		{
			get => GetProperty(ref _checkGain);
			set => SetProperty(ref _checkGain, value);
		}

		public StatPoolChangeOverTimePrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
