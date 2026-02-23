using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterEventSpawnerData : CVariable
	{
		private CName _dataName;
		private inkWidgetReference _targetSpawner;
		private inkWidgetReference _tiedSpawner;
		private CEnum<gameuiarcadeShooterTriggerType> _triggerCondition;
		private CFloat _delayDuration;

		[Ordinal(0)] 
		[RED("dataName")] 
		public CName DataName
		{
			get => GetProperty(ref _dataName);
			set => SetProperty(ref _dataName, value);
		}

		[Ordinal(1)] 
		[RED("targetSpawner")] 
		public inkWidgetReference TargetSpawner
		{
			get => GetProperty(ref _targetSpawner);
			set => SetProperty(ref _targetSpawner, value);
		}

		[Ordinal(2)] 
		[RED("tiedSpawner")] 
		public inkWidgetReference TiedSpawner
		{
			get => GetProperty(ref _tiedSpawner);
			set => SetProperty(ref _tiedSpawner, value);
		}

		[Ordinal(3)] 
		[RED("triggerCondition")] 
		public CEnum<gameuiarcadeShooterTriggerType> TriggerCondition
		{
			get => GetProperty(ref _triggerCondition);
			set => SetProperty(ref _triggerCondition, value);
		}

		[Ordinal(4)] 
		[RED("delayDuration")] 
		public CFloat DelayDuration
		{
			get => GetProperty(ref _delayDuration);
			set => SetProperty(ref _delayDuration, value);
		}

		public gameuiarcadeShooterEventSpawnerData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
