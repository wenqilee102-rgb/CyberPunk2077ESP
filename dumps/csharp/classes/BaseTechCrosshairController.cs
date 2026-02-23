using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseTechCrosshairController : gameuiCrosshairBaseGameController
	{
		private wCHandle<gameObject> _player;
		private CHandle<gameStatsSystem> _statsSystem;
		private CBool _fullChargeAvailable;
		private CBool _overChargeAvailable;
		private CHandle<CrosshairWeaponStatsListener> _fullChargeListener;
		private CHandle<CrosshairWeaponStatsListener> _overChargeListener;

		[Ordinal(29)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(30)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(31)] 
		[RED("fullChargeAvailable")] 
		public CBool FullChargeAvailable
		{
			get => GetProperty(ref _fullChargeAvailable);
			set => SetProperty(ref _fullChargeAvailable, value);
		}

		[Ordinal(32)] 
		[RED("overChargeAvailable")] 
		public CBool OverChargeAvailable
		{
			get => GetProperty(ref _overChargeAvailable);
			set => SetProperty(ref _overChargeAvailable, value);
		}

		[Ordinal(33)] 
		[RED("fullChargeListener")] 
		public CHandle<CrosshairWeaponStatsListener> FullChargeListener
		{
			get => GetProperty(ref _fullChargeListener);
			set => SetProperty(ref _fullChargeListener, value);
		}

		[Ordinal(34)] 
		[RED("overChargeListener")] 
		public CHandle<CrosshairWeaponStatsListener> OverChargeListener
		{
			get => GetProperty(ref _overChargeListener);
			set => SetProperty(ref _overChargeListener, value);
		}

		public BaseTechCrosshairController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
