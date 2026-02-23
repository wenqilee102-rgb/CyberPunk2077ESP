using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolChangeOverTimePrereqState : gamePrereqState
	{
		private CHandle<BaseStatPoolPrereqListener> _statPoolListener;
		private gameStatsObjectID _ownerID;
		private CFloat _valueToCheck;
		private CFloat _timeFrame;
		private CBool _comparePercentage;
		private CBool _checkGain;
		private CArray<ChangeInfoWithTimeStamp> _history;
		private ScriptGameInstance _gameInstance;

		[Ordinal(0)] 
		[RED("statPoolListener")] 
		public CHandle<BaseStatPoolPrereqListener> StatPoolListener
		{
			get => GetProperty(ref _statPoolListener);
			set => SetProperty(ref _statPoolListener, value);
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public gameStatsObjectID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(2)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get => GetProperty(ref _valueToCheck);
			set => SetProperty(ref _valueToCheck, value);
		}

		[Ordinal(3)] 
		[RED("timeFrame")] 
		public CFloat TimeFrame
		{
			get => GetProperty(ref _timeFrame);
			set => SetProperty(ref _timeFrame, value);
		}

		[Ordinal(4)] 
		[RED("comparePercentage")] 
		public CBool ComparePercentage
		{
			get => GetProperty(ref _comparePercentage);
			set => SetProperty(ref _comparePercentage, value);
		}

		[Ordinal(5)] 
		[RED("checkGain")] 
		public CBool CheckGain
		{
			get => GetProperty(ref _checkGain);
			set => SetProperty(ref _checkGain, value);
		}

		[Ordinal(6)] 
		[RED("history")] 
		public CArray<ChangeInfoWithTimeStamp> History
		{
			get => GetProperty(ref _history);
			set => SetProperty(ref _history, value);
		}

		[Ordinal(7)] 
		[RED("GameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		public StatPoolChangeOverTimePrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
