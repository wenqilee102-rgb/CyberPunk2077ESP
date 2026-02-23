using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerForceStat_NodeType : questIEntityManager_NodeType
	{
		private gameEntityReference _objectRef;
		private CBool _isPlayer;
		private CEnum<gamedataStatType> _statType;
		private CFloat _value;
		private CBool _unforce;
		private CName _debugSource;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(3)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(4)] 
		[RED("unforce")] 
		public CBool Unforce
		{
			get => GetProperty(ref _unforce);
			set => SetProperty(ref _unforce, value);
		}

		[Ordinal(5)] 
		[RED("debugSource")] 
		public CName DebugSource
		{
			get => GetProperty(ref _debugSource);
			set => SetProperty(ref _debugSource, value);
		}

		public questEntityManagerForceStat_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
