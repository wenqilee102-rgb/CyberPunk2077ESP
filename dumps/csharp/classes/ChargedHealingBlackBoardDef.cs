using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargedHealingBlackBoardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _currHealingItemCharge;
		private gamebbScriptID_Bool _rechargeGoingOn;

		[Ordinal(0)] 
		[RED("currHealingItemCharge")] 
		public gamebbScriptID_Int32 CurrHealingItemCharge
		{
			get => GetProperty(ref _currHealingItemCharge);
			set => SetProperty(ref _currHealingItemCharge, value);
		}

		[Ordinal(1)] 
		[RED("rechargeGoingOn")] 
		public gamebbScriptID_Bool RechargeGoingOn
		{
			get => GetProperty(ref _rechargeGoingOn);
			set => SetProperty(ref _rechargeGoingOn, value);
		}

		public ChargedHealingBlackBoardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
