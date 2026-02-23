using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageEffector : ModifyAttackEffector
	{
		private CEnum<EMathOperator> _operationType;
		private CFloat _value;
		private CEnum<gamedataStatType> _statType;
		private entEntityID _ownerID;
		private CHandle<ModifyDamageEffectorStatListener> _statListener;
		private CFloat _statBasedValue;

		[Ordinal(0)] 
		[RED("operationType")] 
		public CEnum<EMathOperator> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(3)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(4)] 
		[RED("statListener")] 
		public CHandle<ModifyDamageEffectorStatListener> StatListener
		{
			get => GetProperty(ref _statListener);
			set => SetProperty(ref _statListener, value);
		}

		[Ordinal(5)] 
		[RED("statBasedValue")] 
		public CFloat StatBasedValue
		{
			get => GetProperty(ref _statBasedValue);
			set => SetProperty(ref _statBasedValue, value);
		}

		public ModifyDamageEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
