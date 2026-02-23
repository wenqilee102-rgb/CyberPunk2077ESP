using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessengerTypingIndicator : inkWidgetLogicController
	{
		private inkWidgetReference _container;
		private inkTextWidgetReference _nameText;
		private CHandle<textTextParameterSet> _textParams;

		[Ordinal(1)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(2)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get => GetProperty(ref _nameText);
			set => SetProperty(ref _nameText, value);
		}

		[Ordinal(3)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get => GetProperty(ref _textParams);
			set => SetProperty(ref _textParams, value);
		}

		public MessengerTypingIndicator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
