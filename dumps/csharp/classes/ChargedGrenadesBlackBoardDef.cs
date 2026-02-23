using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargedGrenadesBlackBoardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _curentGrenadeCharges;
		private gamebbScriptID_Int32 _maxGrenadeCharges;
		private gamebbScriptID_Bool _rechargeGoingOn;

		[Ordinal(0)] 
		[RED("curentGrenadeCharges")] 
		public gamebbScriptID_Int32 CurentGrenadeCharges
		{
			get => GetProperty(ref _curentGrenadeCharges);
			set => SetProperty(ref _curentGrenadeCharges, value);
		}

		[Ordinal(1)] 
		[RED("maxGrenadeCharges")] 
		public gamebbScriptID_Int32 MaxGrenadeCharges
		{
			get => GetProperty(ref _maxGrenadeCharges);
			set => SetProperty(ref _maxGrenadeCharges, value);
		}

		[Ordinal(2)] 
		[RED("rechargeGoingOn")] 
		public gamebbScriptID_Bool RechargeGoingOn
		{
			get => GetProperty(ref _rechargeGoingOn);
			set => SetProperty(ref _rechargeGoingOn, value);
		}

		public ChargedGrenadesBlackBoardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
