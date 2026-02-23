using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReloadFromEmptyPrereq : gameIScriptablePrereq
	{
		private CInt32 _minAmountOfAmmoReloaded;

		[Ordinal(0)] 
		[RED("minAmountOfAmmoReloaded")] 
		public CInt32 MinAmountOfAmmoReloaded
		{
			get => GetProperty(ref _minAmountOfAmmoReloaded);
			set => SetProperty(ref _minAmountOfAmmoReloaded, value);
		}

		public ReloadFromEmptyPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
