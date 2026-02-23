using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponDisplayController : InventoryItemDisplayController
	{
		private inkCompoundWidgetReference _weaponSpecyficModsRoot;
		private inkWidgetReference _silencerIcon;
		private inkWidgetReference _scopeIcon;
		private inkImageWidgetReference _ammoIcon;
		private CArray<wCHandle<InventoryItemPartDisplay>> _weaponAttachmentsDisplay;

		[Ordinal(120)] 
		[RED("weaponSpecyficModsRoot")] 
		public inkCompoundWidgetReference WeaponSpecyficModsRoot
		{
			get => GetProperty(ref _weaponSpecyficModsRoot);
			set => SetProperty(ref _weaponSpecyficModsRoot, value);
		}

		[Ordinal(121)] 
		[RED("silencerIcon")] 
		public inkWidgetReference SilencerIcon
		{
			get => GetProperty(ref _silencerIcon);
			set => SetProperty(ref _silencerIcon, value);
		}

		[Ordinal(122)] 
		[RED("scopeIcon")] 
		public inkWidgetReference ScopeIcon
		{
			get => GetProperty(ref _scopeIcon);
			set => SetProperty(ref _scopeIcon, value);
		}

		[Ordinal(123)] 
		[RED("ammoIcon")] 
		public inkImageWidgetReference AmmoIcon
		{
			get => GetProperty(ref _ammoIcon);
			set => SetProperty(ref _ammoIcon, value);
		}

		[Ordinal(124)] 
		[RED("weaponAttachmentsDisplay")] 
		public CArray<wCHandle<InventoryItemPartDisplay>> WeaponAttachmentsDisplay
		{
			get => GetProperty(ref _weaponAttachmentsDisplay);
			set => SetProperty(ref _weaponAttachmentsDisplay, value);
		}

		public InventoryWeaponDisplayController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
