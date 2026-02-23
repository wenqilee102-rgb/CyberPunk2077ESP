using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCinematicCameraShotGroup : IScriptable
	{
		private CString _name;
		private CArray<CHandle<vehicleCinematicCameraShotStartCondition>> _conditions;
		private CArray<vehicleCinematicCameraShot> _shots;
		private CBool _enabled;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<vehicleCinematicCameraShotStartCondition>> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}

		[Ordinal(2)] 
		[RED("shots")] 
		public CArray<vehicleCinematicCameraShot> Shots
		{
			get => GetProperty(ref _shots);
			set => SetProperty(ref _shots, value);
		}

		[Ordinal(3)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		public vehicleCinematicCameraShotGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
