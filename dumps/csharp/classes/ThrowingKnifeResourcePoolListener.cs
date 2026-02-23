using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowingKnifeResourcePoolListener : gameScriptStatPoolsListener
	{
		private wCHandle<Crosshair_Melee_Knife> _crosshair;
		private CBool _shouldDisplayBar;
		private CHandle<ThrowingKnifeReloadFinishedCrosshairEvent> _evt;

		[Ordinal(0)] 
		[RED("Crosshair")] 
		public wCHandle<Crosshair_Melee_Knife> Crosshair
		{
			get => GetProperty(ref _crosshair);
			set => SetProperty(ref _crosshair, value);
		}

		[Ordinal(1)] 
		[RED("shouldDisplayBar")] 
		public CBool ShouldDisplayBar
		{
			get => GetProperty(ref _shouldDisplayBar);
			set => SetProperty(ref _shouldDisplayBar, value);
		}

		[Ordinal(2)] 
		[RED("evt")] 
		public CHandle<ThrowingKnifeReloadFinishedCrosshairEvent> Evt
		{
			get => GetProperty(ref _evt);
			set => SetProperty(ref _evt, value);
		}

		public ThrowingKnifeResourcePoolListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
