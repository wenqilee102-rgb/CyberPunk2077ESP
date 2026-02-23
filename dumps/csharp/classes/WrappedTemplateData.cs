using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WrappedTemplateData : IScriptable
	{
		private wCHandle<TwintoneTemplateGridController> _parentGridController;
		private VehicleVisualCustomizationTemplate _template;
		private CUInt32 _indexInList;
		private CBool _canAcceptSave;

		[Ordinal(0)] 
		[RED("parentGridController")] 
		public wCHandle<TwintoneTemplateGridController> ParentGridController
		{
			get => GetProperty(ref _parentGridController);
			set => SetProperty(ref _parentGridController, value);
		}

		[Ordinal(1)] 
		[RED("template")] 
		public VehicleVisualCustomizationTemplate Template
		{
			get => GetProperty(ref _template);
			set => SetProperty(ref _template, value);
		}

		[Ordinal(2)] 
		[RED("indexInList")] 
		public CUInt32 IndexInList
		{
			get => GetProperty(ref _indexInList);
			set => SetProperty(ref _indexInList, value);
		}

		[Ordinal(3)] 
		[RED("canAcceptSave")] 
		public CBool CanAcceptSave
		{
			get => GetProperty(ref _canAcceptSave);
			set => SetProperty(ref _canAcceptSave, value);
		}

		public WrappedTemplateData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
