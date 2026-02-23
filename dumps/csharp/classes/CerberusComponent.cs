using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CerberusComponent : gameScriptableComponent
	{
		private CHandle<gameEffectInstance> _laserGameEffectUp;
		private gameEffectRef _laserGameEffectRefUp;
		private CHandle<gameEffectInstance> _laserGameEffectUp2;
		private gameEffectRef _laserGameEffectRefUp2;
		private CHandle<gameEffectInstance> _laserGameEffectBeam;
		private gameEffectRef _laserGameEffectRefBeam;
		private CHandle<gameEffectInstance> _laserGameEffectBottom;
		private gameEffectRef _laserGameEffectRefBottom;
		private CHandle<gameEffectInstance> _laserGameEffectBottom2;
		private gameEffectRef _laserGameEffectRefBottom2;
		private wCHandle<gameObject> _gameObject;

		[Ordinal(5)] 
		[RED("laserGameEffectUp")] 
		public CHandle<gameEffectInstance> LaserGameEffectUp
		{
			get => GetProperty(ref _laserGameEffectUp);
			set => SetProperty(ref _laserGameEffectUp, value);
		}

		[Ordinal(6)] 
		[RED("laserGameEffectRefUp")] 
		public gameEffectRef LaserGameEffectRefUp
		{
			get => GetProperty(ref _laserGameEffectRefUp);
			set => SetProperty(ref _laserGameEffectRefUp, value);
		}

		[Ordinal(7)] 
		[RED("laserGameEffectUp2")] 
		public CHandle<gameEffectInstance> LaserGameEffectUp2
		{
			get => GetProperty(ref _laserGameEffectUp2);
			set => SetProperty(ref _laserGameEffectUp2, value);
		}

		[Ordinal(8)] 
		[RED("laserGameEffectRefUp2")] 
		public gameEffectRef LaserGameEffectRefUp2
		{
			get => GetProperty(ref _laserGameEffectRefUp2);
			set => SetProperty(ref _laserGameEffectRefUp2, value);
		}

		[Ordinal(9)] 
		[RED("laserGameEffectBeam")] 
		public CHandle<gameEffectInstance> LaserGameEffectBeam
		{
			get => GetProperty(ref _laserGameEffectBeam);
			set => SetProperty(ref _laserGameEffectBeam, value);
		}

		[Ordinal(10)] 
		[RED("laserGameEffectRefBeam")] 
		public gameEffectRef LaserGameEffectRefBeam
		{
			get => GetProperty(ref _laserGameEffectRefBeam);
			set => SetProperty(ref _laserGameEffectRefBeam, value);
		}

		[Ordinal(11)] 
		[RED("laserGameEffectBottom")] 
		public CHandle<gameEffectInstance> LaserGameEffectBottom
		{
			get => GetProperty(ref _laserGameEffectBottom);
			set => SetProperty(ref _laserGameEffectBottom, value);
		}

		[Ordinal(12)] 
		[RED("laserGameEffectRefBottom")] 
		public gameEffectRef LaserGameEffectRefBottom
		{
			get => GetProperty(ref _laserGameEffectRefBottom);
			set => SetProperty(ref _laserGameEffectRefBottom, value);
		}

		[Ordinal(13)] 
		[RED("laserGameEffectBottom2")] 
		public CHandle<gameEffectInstance> LaserGameEffectBottom2
		{
			get => GetProperty(ref _laserGameEffectBottom2);
			set => SetProperty(ref _laserGameEffectBottom2, value);
		}

		[Ordinal(14)] 
		[RED("laserGameEffectRefBottom2")] 
		public gameEffectRef LaserGameEffectRefBottom2
		{
			get => GetProperty(ref _laserGameEffectRefBottom2);
			set => SetProperty(ref _laserGameEffectRefBottom2, value);
		}

		[Ordinal(15)] 
		[RED("gameObject")] 
		public wCHandle<gameObject> GameObject
		{
			get => GetProperty(ref _gameObject);
			set => SetProperty(ref _gameObject, value);
		}

		public CerberusComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
