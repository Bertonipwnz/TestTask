using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestTaskUWP.ViewModels
{
	/// <summary>
	/// Базовый ViewModel для привязки данных и уведомлений, в данном случаи расширенный
	/// </summary>
	public class BaseViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		
		protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string property = null)
		{
			if (EqualityComparer<T>.Default.Equals(field, value)) return false;
			field = value;
			RaisePropertyChanged(property);
			return true;
		}

		
		protected void SetProperty<T>(T currentValue, T newValue, Action doSet, [CallerMemberName] string property = null)
		{
			if (EqualityComparer<T>.Default.Equals(currentValue, newValue)) return;
			doSet.Invoke();
			RaisePropertyChanged(property);
		}

		private void RaisePropertyChanged(string property)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
		}
	}

	public class BaseViewModel<T> : BaseViewModel where T : class, new()
	{
		protected readonly T This;

		public static implicit operator T(BaseViewModel<T> thing) { return thing.This; }

		protected BaseViewModel(T thing = null)
		{
			This = thing ?? new T();
		}
	}
}
