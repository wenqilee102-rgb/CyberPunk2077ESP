using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BloodswellEffector : gameEffector
	{
		private CHandle<BloodswellEffectorHealthListener> _deathListener;
		private CHandle<BloodswellEffectorColdBloodListener> _coldBloodListener;
		private ScriptGameInstance _gameInstance;
		private wCHandle<gameObject> _owner;
		private CBool _isImmortal;

		[Ordinal(0)] 
		[RED("deathListener")] 
		public CHandle<BloodswellEffectorHealthListener> DeathListener
		{
			get => GetProperty(ref _deathListener);
			set => SetProperty(ref _deathListener, value);
		}

		[Ordinal(1)] 
		[RED("coldBloodListener")] 
		public CHandle<BloodswellEffectorColdBloodListener> ColdBloodListener
		{
			get => GetProperty(ref _coldBloodListener);
			set => SetProperty(ref _coldBloodListener, value);
		}

		[Ordinal(2)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(4)] 
		[RED("isImmortal")] 
		public CBool IsImmortal
		{
			get => GetProperty(ref _isImmortal);
			set => SetProperty(ref _isImmortal, value);
		}

		public BloodswellEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
