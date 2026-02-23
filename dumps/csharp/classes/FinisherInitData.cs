using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FinisherInitData : IScriptable
	{
		private wCHandle<gameObject> _target;
		private CName _actionName;
		private CBool _isBossFinisher;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		[Ordinal(2)] 
		[RED("IsBossFinisher")] 
		public CBool IsBossFinisher
		{
			get => GetProperty(ref _isBossFinisher);
			set => SetProperty(ref _isBossFinisher, value);
		}

		public FinisherInitData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
