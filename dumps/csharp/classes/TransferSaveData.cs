using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TransferSaveData : IScriptable
	{
		private CInt32 _saveIndex;
		private CEnum<TransferSaveAction> _action;

		[Ordinal(0)] 
		[RED("saveIndex")] 
		public CInt32 SaveIndex
		{
			get => GetProperty(ref _saveIndex);
			set => SetProperty(ref _saveIndex, value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<TransferSaveAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		public TransferSaveData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
