using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterResult : CVariable
	{
		private CBool _success;
		private CBool _isVehicle;
		private CEnum<gameDynamicVehicleType> _spawnedType;

		[Ordinal(0)] 
		[RED("success")] 
		public CBool Success
		{
			get => GetProperty(ref _success);
			set => SetProperty(ref _success, value);
		}

		[Ordinal(1)] 
		[RED("isVehicle")] 
		public CBool IsVehicle
		{
			get => GetProperty(ref _isVehicle);
			set => SetProperty(ref _isVehicle, value);
		}

		[Ordinal(2)] 
		[RED("spawnedType")] 
		public CEnum<gameDynamicVehicleType> SpawnedType
		{
			get => GetProperty(ref _spawnedType);
			set => SetProperty(ref _spawnedType, value);
		}

		public UnregisterResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
