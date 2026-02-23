using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckYaibaOption : inkWidgetLogicController
	{
		private inkWidgetReference _checkBox;
		private inkWidgetReference _checkMark;
		private CEnum<MuramasaOption> _option;
		private CFloat _defaultOpacity;
		private CBool _isChecked;
		private CBool _isHovered;
		private CBool _isEnabled;
		private wCHandle<YaibaOptionPreview> _previewController;

		[Ordinal(1)] 
		[RED("checkBox")] 
		public inkWidgetReference CheckBox
		{
			get => GetProperty(ref _checkBox);
			set => SetProperty(ref _checkBox, value);
		}

		[Ordinal(2)] 
		[RED("checkMark")] 
		public inkWidgetReference CheckMark
		{
			get => GetProperty(ref _checkMark);
			set => SetProperty(ref _checkMark, value);
		}

		[Ordinal(3)] 
		[RED("option")] 
		public CEnum<MuramasaOption> Option
		{
			get => GetProperty(ref _option);
			set => SetProperty(ref _option, value);
		}

		[Ordinal(4)] 
		[RED("defaultOpacity")] 
		public CFloat DefaultOpacity
		{
			get => GetProperty(ref _defaultOpacity);
			set => SetProperty(ref _defaultOpacity, value);
		}

		[Ordinal(5)] 
		[RED("isChecked")] 
		public CBool IsChecked
		{
			get => GetProperty(ref _isChecked);
			set => SetProperty(ref _isChecked, value);
		}

		[Ordinal(6)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetProperty(ref _isHovered);
			set => SetProperty(ref _isHovered, value);
		}

		[Ordinal(7)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(8)] 
		[RED("previewController")] 
		public wCHandle<YaibaOptionPreview> PreviewController
		{
			get => GetProperty(ref _previewController);
			set => SetProperty(ref _previewController, value);
		}

		public CheckYaibaOption(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
