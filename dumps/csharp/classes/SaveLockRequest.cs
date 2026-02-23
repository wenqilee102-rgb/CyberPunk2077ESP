using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SaveLockRequest : gameScriptableSystemRequest
	{
		private CEnum<EItemOperationType> _operation;
		private CName _reason;

		[Ordinal(0)] 
		[RED("operation")] 
		public CEnum<EItemOperationType> Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}

		public SaveLockRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
