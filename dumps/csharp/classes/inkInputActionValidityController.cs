using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkInputActionValidityController : inkWidgetLogicController
	{
		private CBool _invertVisibility;
		private CName _inputActionName;
		private CArray<inkWidgetReference> _inputValidityDependentWidgets;

		[Ordinal(1)] 
		[RED("invertVisibility")] 
		public CBool InvertVisibility
		{
			get => GetProperty(ref _invertVisibility);
			set => SetProperty(ref _invertVisibility, value);
		}

		[Ordinal(2)] 
		[RED("inputActionName")] 
		public CName InputActionName
		{
			get => GetProperty(ref _inputActionName);
			set => SetProperty(ref _inputActionName, value);
		}

		[Ordinal(3)] 
		[RED("inputValidityDependentWidgets")] 
		public CArray<inkWidgetReference> InputValidityDependentWidgets
		{
			get => GetProperty(ref _inputValidityDependentWidgets);
			set => SetProperty(ref _inputValidityDependentWidgets, value);
		}

		public inkInputActionValidityController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
