using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AimAtTargetCommandTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inCommand;
		private wCHandle<AIAimAtTargetCommand> _currentCommand;
		private CHandle<gamedataAIThreatPersistenceSource_Record> _threatPersistenceSource;
		private CFloat _activationTimeStamp;
		private CFloat _commandDuration;
		private wCHandle<gameObject> _target;
		private entEntityID _targetID;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetProperty(ref _inCommand);
			set => SetProperty(ref _inCommand, value);
		}

		[Ordinal(1)] 
		[RED("currentCommand")] 
		public wCHandle<AIAimAtTargetCommand> CurrentCommand
		{
			get => GetProperty(ref _currentCommand);
			set => SetProperty(ref _currentCommand, value);
		}

		[Ordinal(2)] 
		[RED("threatPersistenceSource")] 
		public CHandle<gamedataAIThreatPersistenceSource_Record> ThreatPersistenceSource
		{
			get => GetProperty(ref _threatPersistenceSource);
			set => SetProperty(ref _threatPersistenceSource, value);
		}

		[Ordinal(3)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetProperty(ref _activationTimeStamp);
			set => SetProperty(ref _activationTimeStamp, value);
		}

		[Ordinal(4)] 
		[RED("commandDuration")] 
		public CFloat CommandDuration
		{
			get => GetProperty(ref _commandDuration);
			set => SetProperty(ref _commandDuration, value);
		}

		[Ordinal(5)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(6)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		public AimAtTargetCommandTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
