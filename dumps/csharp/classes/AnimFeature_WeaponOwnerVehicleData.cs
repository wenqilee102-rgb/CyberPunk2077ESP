using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponOwnerVehicleData : animAnimFeature
	{
		private CBool _isOwnerDriver;
		private CBool _isOwnerMountedToVehicle;

		[Ordinal(0)] 
		[RED("isOwnerDriver")] 
		public CBool IsOwnerDriver
		{
			get => GetProperty(ref _isOwnerDriver);
			set => SetProperty(ref _isOwnerDriver, value);
		}

		[Ordinal(1)] 
		[RED("isOwnerMountedToVehicle")] 
		public CBool IsOwnerMountedToVehicle
		{
			get => GetProperty(ref _isOwnerMountedToVehicle);
			set => SetProperty(ref _isOwnerMountedToVehicle, value);
		}

		public AnimFeature_WeaponOwnerVehicleData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
