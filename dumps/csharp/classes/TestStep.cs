using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TestStep : IScriptable
	{
		private CName _stepName;
		private CUInt16 _scriptId;
		private CString _reproStep;
		private CArray<CVariant> _args;
		private CFloat _stepTimeout;
		private CBool _stopTestOnFailure;

		[Ordinal(0)] 
		[RED("stepName")] 
		public CName StepName
		{
			get => GetProperty(ref _stepName);
			set => SetProperty(ref _stepName, value);
		}

		[Ordinal(1)] 
		[RED("scriptId")] 
		public CUInt16 ScriptId
		{
			get => GetProperty(ref _scriptId);
			set => SetProperty(ref _scriptId, value);
		}

		[Ordinal(2)] 
		[RED("reproStep")] 
		public CString ReproStep
		{
			get => GetProperty(ref _reproStep);
			set => SetProperty(ref _reproStep, value);
		}

		[Ordinal(3)] 
		[RED("args")] 
		public CArray<CVariant> Args
		{
			get => GetProperty(ref _args);
			set => SetProperty(ref _args, value);
		}

		[Ordinal(4)] 
		[RED("stepTimeout")] 
		public CFloat StepTimeout
		{
			get => GetProperty(ref _stepTimeout);
			set => SetProperty(ref _stepTimeout, value);
		}

		[Ordinal(5)] 
		[RED("stopTestOnFailure")] 
		public CBool StopTestOnFailure
		{
			get => GetProperty(ref _stopTestOnFailure);
			set => SetProperty(ref _stopTestOnFailure, value);
		}

		public TestStep(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
