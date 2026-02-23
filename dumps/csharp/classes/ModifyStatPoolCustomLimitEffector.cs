using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatPoolCustomLimitEffector : gameEffector
	{
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CFloat _value;
		private CBool _usePercent;
		private CFloat _previousLimit;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("usePercent")] 
		public CBool UsePercent
		{
			get => GetProperty(ref _usePercent);
			set => SetProperty(ref _usePercent, value);
		}

		[Ordinal(3)] 
		[RED("previousLimit")] 
		public CFloat PreviousLimit
		{
			get => GetProperty(ref _previousLimit);
			set => SetProperty(ref _previousLimit, value);
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public ModifyStatPoolCustomLimitEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
