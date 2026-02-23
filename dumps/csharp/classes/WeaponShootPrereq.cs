using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponShootPrereq : gameIScriptablePrereq
	{
		private CInt32 _howManyAttacks;

		[Ordinal(0)] 
		[RED("howManyAttacks")] 
		public CInt32 HowManyAttacks
		{
			get => GetProperty(ref _howManyAttacks);
			set => SetProperty(ref _howManyAttacks, value);
		}

		public WeaponShootPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
