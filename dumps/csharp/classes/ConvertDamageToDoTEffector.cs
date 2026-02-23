using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConvertDamageToDoTEffector : ModifyAttackEffector
	{
		private CFloat _damageToDoTConversion;
		private CFloat _dotDistributionTime;
		private CHandle<gameConstantStatModifierData_Deprecated> _statMod;
		private entEntityID _ownerID;

		[Ordinal(0)] 
		[RED("DamageToDoTConversion")] 
		public CFloat DamageToDoTConversion
		{
			get => GetProperty(ref _damageToDoTConversion);
			set => SetProperty(ref _damageToDoTConversion, value);
		}

		[Ordinal(1)] 
		[RED("DotDistributionTime")] 
		public CFloat DotDistributionTime
		{
			get => GetProperty(ref _dotDistributionTime);
			set => SetProperty(ref _dotDistributionTime, value);
		}

		[Ordinal(2)] 
		[RED("statMod")] 
		public CHandle<gameConstantStatModifierData_Deprecated> StatMod
		{
			get => GetProperty(ref _statMod);
			set => SetProperty(ref _statMod, value);
		}

		[Ordinal(3)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		public ConvertDamageToDoTEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
