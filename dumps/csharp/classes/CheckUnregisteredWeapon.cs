using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckUnregisteredWeapon : AIItemHandlingCondition
	{
		private CArray<TweakDBID> _primaryItemArrayRecordTweakDBID;
		private CArray<TweakDBID> _secondaryItemArrayRecordTweakDBID;
		private CHandle<gameTransactionSystem> _transactionSystem;
		private wCHandle<ScriptedPuppet> _puppet;
		private CBool _initialized;

		[Ordinal(0)] 
		[RED("primaryItemArrayRecordTweakDBID")] 
		public CArray<TweakDBID> PrimaryItemArrayRecordTweakDBID
		{
			get => GetProperty(ref _primaryItemArrayRecordTweakDBID);
			set => SetProperty(ref _primaryItemArrayRecordTweakDBID, value);
		}

		[Ordinal(1)] 
		[RED("secondaryItemArrayRecordTweakDBID")] 
		public CArray<TweakDBID> SecondaryItemArrayRecordTweakDBID
		{
			get => GetProperty(ref _secondaryItemArrayRecordTweakDBID);
			set => SetProperty(ref _secondaryItemArrayRecordTweakDBID, value);
		}

		[Ordinal(2)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(3)] 
		[RED("puppet")] 
		public wCHandle<ScriptedPuppet> Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		[Ordinal(4)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		public CheckUnregisteredWeapon(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
