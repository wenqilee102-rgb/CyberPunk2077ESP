using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CaptionImageIconsLogicController : inkWidgetLogicController
	{
		private inkImageWidgetReference _genericIcon;
		private inkCompoundWidgetReference _genericHolder;
		private inkImageWidgetReference _lifeIcon;
		private inkTextWidgetReference _lifeDescriptionText;
		private inkWidgetReference _lifeBackground;
		private inkWidgetReference _lifeBackgroundFail;
		private inkCompoundWidgetReference _lifeWrapper;
		private inkCompoundWidgetReference _lifeHolder;
		private inkImageWidgetReference _checkIcon;
		private inkTextWidgetReference _checkText;
		private inkCompoundWidgetReference _checkHolder;
		private inkWidgetReference _checkBackground;
		private inkWidgetReference _checkBackgroundFail;
		private inkImageWidgetReference _payIcon;
		private inkTextWidgetReference _payText;
		private inkWidgetReference _payBackground;
		private inkWidgetReference _payBackgroundFail;
		private inkCompoundWidgetReference _payWrapper;
		private inkCompoundWidgetReference _payHolder;

		[Ordinal(1)] 
		[RED("GenericIcon")] 
		public inkImageWidgetReference GenericIcon
		{
			get => GetProperty(ref _genericIcon);
			set => SetProperty(ref _genericIcon, value);
		}

		[Ordinal(2)] 
		[RED("GenericHolder")] 
		public inkCompoundWidgetReference GenericHolder
		{
			get => GetProperty(ref _genericHolder);
			set => SetProperty(ref _genericHolder, value);
		}

		[Ordinal(3)] 
		[RED("LifeIcon")] 
		public inkImageWidgetReference LifeIcon
		{
			get => GetProperty(ref _lifeIcon);
			set => SetProperty(ref _lifeIcon, value);
		}

		[Ordinal(4)] 
		[RED("LifeDescriptionText")] 
		public inkTextWidgetReference LifeDescriptionText
		{
			get => GetProperty(ref _lifeDescriptionText);
			set => SetProperty(ref _lifeDescriptionText, value);
		}

		[Ordinal(5)] 
		[RED("LifeBackground")] 
		public inkWidgetReference LifeBackground
		{
			get => GetProperty(ref _lifeBackground);
			set => SetProperty(ref _lifeBackground, value);
		}

		[Ordinal(6)] 
		[RED("LifeBackgroundFail")] 
		public inkWidgetReference LifeBackgroundFail
		{
			get => GetProperty(ref _lifeBackgroundFail);
			set => SetProperty(ref _lifeBackgroundFail, value);
		}

		[Ordinal(7)] 
		[RED("LifeWrapper")] 
		public inkCompoundWidgetReference LifeWrapper
		{
			get => GetProperty(ref _lifeWrapper);
			set => SetProperty(ref _lifeWrapper, value);
		}

		[Ordinal(8)] 
		[RED("LifeHolder")] 
		public inkCompoundWidgetReference LifeHolder
		{
			get => GetProperty(ref _lifeHolder);
			set => SetProperty(ref _lifeHolder, value);
		}

		[Ordinal(9)] 
		[RED("CheckIcon")] 
		public inkImageWidgetReference CheckIcon
		{
			get => GetProperty(ref _checkIcon);
			set => SetProperty(ref _checkIcon, value);
		}

		[Ordinal(10)] 
		[RED("CheckText")] 
		public inkTextWidgetReference CheckText
		{
			get => GetProperty(ref _checkText);
			set => SetProperty(ref _checkText, value);
		}

		[Ordinal(11)] 
		[RED("CheckHolder")] 
		public inkCompoundWidgetReference CheckHolder
		{
			get => GetProperty(ref _checkHolder);
			set => SetProperty(ref _checkHolder, value);
		}

		[Ordinal(12)] 
		[RED("CheckBackground")] 
		public inkWidgetReference CheckBackground
		{
			get => GetProperty(ref _checkBackground);
			set => SetProperty(ref _checkBackground, value);
		}

		[Ordinal(13)] 
		[RED("CheckBackgroundFail")] 
		public inkWidgetReference CheckBackgroundFail
		{
			get => GetProperty(ref _checkBackgroundFail);
			set => SetProperty(ref _checkBackgroundFail, value);
		}

		[Ordinal(14)] 
		[RED("PayIcon")] 
		public inkImageWidgetReference PayIcon
		{
			get => GetProperty(ref _payIcon);
			set => SetProperty(ref _payIcon, value);
		}

		[Ordinal(15)] 
		[RED("PayText")] 
		public inkTextWidgetReference PayText
		{
			get => GetProperty(ref _payText);
			set => SetProperty(ref _payText, value);
		}

		[Ordinal(16)] 
		[RED("PayBackground")] 
		public inkWidgetReference PayBackground
		{
			get => GetProperty(ref _payBackground);
			set => SetProperty(ref _payBackground, value);
		}

		[Ordinal(17)] 
		[RED("PayBackgroundFail")] 
		public inkWidgetReference PayBackgroundFail
		{
			get => GetProperty(ref _payBackgroundFail);
			set => SetProperty(ref _payBackgroundFail, value);
		}

		[Ordinal(18)] 
		[RED("PayWrapper")] 
		public inkCompoundWidgetReference PayWrapper
		{
			get => GetProperty(ref _payWrapper);
			set => SetProperty(ref _payWrapper, value);
		}

		[Ordinal(19)] 
		[RED("PayHolder")] 
		public inkCompoundWidgetReference PayHolder
		{
			get => GetProperty(ref _payHolder);
			set => SetProperty(ref _payHolder, value);
		}

		public CaptionImageIconsLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
