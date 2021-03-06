﻿// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the SelectableItemViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Scorchio.Infrastructure.Wpf.ViewModels
{
    /// <summary>
    /// Defines the SelectableItemViewModel type.
    /// </summary>
    /// <typeparam name="T">The Type.</typeparam>
    public class SelectableItemViewModel<T> : BaseViewModel
    {
        /// <summary>
        /// The is selected.
        /// </summary>
        private bool isSelected;

        /// <summary>
        /// The item.
        /// </summary>
        private T item;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectableItemViewModel{T}"/> class.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="isSelected">if set to <c>true</c> [is selected].</param>
        public SelectableItemViewModel(
            T item,
            bool isSelected = false)
        {
            this.item = item;
            this.isSelected = isSelected;
        }

        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        public T Item
        {
            get { return this.item; }
            set { this.SetProperty(ref this.item, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [is selected].
        /// </summary>
        public bool IsSelected
        {
            get { return this.isSelected; }
            set { this.SetProperty(ref this.isSelected, value); }
        }
    }
}
