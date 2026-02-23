using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RelicPerkSystem : gameScriptableSystem
	{
		private CArray<CHandle<PerkDeviceMappinData>> _registeredPerkDevices;

		[Ordinal(0)] 
		[RED("registeredPerkDevices")] 
		public CArray<CHandle<PerkDeviceMappinData>> RegisteredPerkDevices
		{
			get => GetProperty(ref _registeredPerkDevices);
			set => SetProperty(ref _registeredPerkDevices, value);
		}

		public RelicPerkSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
