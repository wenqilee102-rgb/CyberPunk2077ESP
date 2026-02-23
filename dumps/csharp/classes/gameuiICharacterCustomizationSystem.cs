using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiICharacterCustomizationSystem : gameIGameSystem
	{
		private wCHandle<gameuiCharacterCreationPuppetPreviewGameController> _puppetPreviewGameController;

		[Ordinal(0)] 
		[RED("puppetPreviewGameController")] 
		public wCHandle<gameuiCharacterCreationPuppetPreviewGameController> PuppetPreviewGameController
		{
			get => GetProperty(ref _puppetPreviewGameController);
			set => SetProperty(ref _puppetPreviewGameController, value);
		}

		public gameuiICharacterCustomizationSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
