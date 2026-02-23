using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_CharacterCustomizationMirror : MenuScenario_BaseMenu
	{
		private CHandle<MorphMenuUserData> _morphMenuUserData;

		[Ordinal(4)] 
		[RED("morphMenuUserData")] 
		public CHandle<MorphMenuUserData> MorphMenuUserData
		{
			get => GetProperty(ref _morphMenuUserData);
			set => SetProperty(ref _morphMenuUserData, value);
		}

		public MenuScenario_CharacterCustomizationMirror(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
