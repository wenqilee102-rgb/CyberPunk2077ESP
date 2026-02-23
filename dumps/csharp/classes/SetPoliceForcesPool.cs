using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetPoliceForcesPool : gameScriptableSystemRequest
	{
		private CBool _disableOnFootSpawn;
		private CBool _disableVehicleSpawn;
		private CBool _disableDroneSpawn;
		private CBool _resetToDefault;
		private CName _source;

		[Ordinal(0)] 
		[RED("disableOnFootSpawn")] 
		public CBool DisableOnFootSpawn
		{
			get => GetProperty(ref _disableOnFootSpawn);
			set => SetProperty(ref _disableOnFootSpawn, value);
		}

		[Ordinal(1)] 
		[RED("disableVehicleSpawn")] 
		public CBool DisableVehicleSpawn
		{
			get => GetProperty(ref _disableVehicleSpawn);
			set => SetProperty(ref _disableVehicleSpawn, value);
		}

		[Ordinal(2)] 
		[RED("disableDroneSpawn")] 
		public CBool DisableDroneSpawn
		{
			get => GetProperty(ref _disableDroneSpawn);
			set => SetProperty(ref _disableDroneSpawn, value);
		}

		[Ordinal(3)] 
		[RED("resetToDefault")] 
		public CBool ResetToDefault
		{
			get => GetProperty(ref _resetToDefault);
			set => SetProperty(ref _resetToDefault, value);
		}

		[Ordinal(4)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public SetPoliceForcesPool(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
