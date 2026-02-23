using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterEventData : CVariable
	{
		private Vector2 _triggerPosition;
		private Vector2 _finalPosition;
		private CArray<gameuiarcadeShooterEventSpawnerData> _spawnerDataList;

		[Ordinal(0)] 
		[RED("triggerPosition")] 
		public Vector2 TriggerPosition
		{
			get => GetProperty(ref _triggerPosition);
			set => SetProperty(ref _triggerPosition, value);
		}

		[Ordinal(1)] 
		[RED("finalPosition")] 
		public Vector2 FinalPosition
		{
			get => GetProperty(ref _finalPosition);
			set => SetProperty(ref _finalPosition, value);
		}

		[Ordinal(2)] 
		[RED("spawnerDataList")] 
		public CArray<gameuiarcadeShooterEventSpawnerData> SpawnerDataList
		{
			get => GetProperty(ref _spawnerDataList);
			set => SetProperty(ref _spawnerDataList, value);
		}

		public gameuiarcadeShooterEventData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
