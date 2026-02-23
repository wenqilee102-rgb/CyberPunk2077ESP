using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlackwallAnimDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _deathAnimNumber;
		private gamebbScriptID_Int32 _handGestureAnimNumber;

		[Ordinal(0)] 
		[RED("deathAnimNumber")] 
		public gamebbScriptID_Int32 DeathAnimNumber
		{
			get => GetProperty(ref _deathAnimNumber);
			set => SetProperty(ref _deathAnimNumber, value);
		}

		[Ordinal(1)] 
		[RED("handGestureAnimNumber")] 
		public gamebbScriptID_Int32 HandGestureAnimNumber
		{
			get => GetProperty(ref _handGestureAnimNumber);
			set => SetProperty(ref _handGestureAnimNumber, value);
		}

		public BlackwallAnimDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
