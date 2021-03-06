﻿using BlazorUtils.Interfaces.EventArgs;
using System;
using System.Threading.Tasks;

namespace BlazorUtils.Interfaces
{
    /// <summary>
    /// Represents a collection of DOM elements with async methods.
    /// </summary>
    public interface IAsyncDom : IDom
    {
        /// <summary>
        /// Set one or more attributes for the set of matched elements.
        /// </summary>
        /// <param name="attribute">The name of the attribute to set.</param>
        /// <param name="value">A value to set for the attribute. If null, the specified attribute will be removed (as in .removeAttr()).</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Attr(string attribute, string value);

        /// <summary>
        /// Display or hide the matched elements.
        /// </summary>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Toggle();

        /// <summary>
        /// Set one or more attributes for the set of matched elements.
        /// </summary>
        /// <param name="attribute">An object of attribute-value pairs to set.</param>
        /// <returns></returns>
        Task<string> Attr(object attribute);

        /// <summary>
        /// Get the current value of the first element in the set of matched elements.
        /// </summary>
        /// <returns>The current value of the first element in the set of matched elements.</returns>
        Task<string> Val();

        /// <summary>
        /// Set the value of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A string of text corresponding to the value of each matched element to set as selected/checked.</param>
        /// <returns></returns>
        Task<IAsyncDom> Val(string value);

        /// <summary>
        /// Get the combined text contents of each element in the set of matched elements, including their descendants.
        /// </summary>
        /// <returns>Text contents of each element.</returns>
        Task<string> Text();

        /// <summary>
        /// Set the text contents of the matched elements.
        /// </summary>
        /// <param name="text">The text to set as the content of each matched element. When Number or Boolean is supplied, it will be converted to a String representation.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Text(string text);

        /// <summary>
        /// Get the computed style properties for the first element in the set of matched elements.
        /// </summary>
        /// <param name="propertyName">A CSS property.</param>
        /// <returns>Computed style properties.</returns>
        Task<string> Css(string propertyName);

        /// <summary>
        /// Set one or more CSS properties for the set of matched elements.
        /// </summary>
        /// <param name="propertyName">A CSS property name.</param>
        /// <param name="value">A value to set for the property.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Css(string propertyName, string value);

        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        /// <param name="properties">An object of CSS properties and values that the animation will move toward.</param>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete, called once per matched element.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Animate(object properties, int duration, string easing, Action complete);

        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        /// <param name="properties">An object of CSS properties and values that the animation will move toward.</param>
        /// <param name="options">A map of additional options to pass to the method.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Animate(object properties, object options);

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="handler">A function to execute when the event is triggered.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> On(string events, Action<LMTEventArgs> handler);

        /// <summary>
        /// Create a new jQuery object with elements added to the set of matched elements.
        /// </summary>
        /// <param name="selector">A string representing a selector expression to find additional elements to add to the set of matched elements.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Add(string selector);

        /// <summary>
        /// Adds the specified class(es) to each element in the set of matched elements.
        /// </summary>
        /// <param name="className">One or more space-separated classes to be added to the class attribute of each matched element.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> AddClass(string className);

        /// <summary>
        /// Determine whether any of the matched elements are assigned the given class.
        /// </summary>
        /// <param name="className">The class name to search for.</param>
        /// <returns>Whether any of the matched elements are assigned the given class.</returns>
        Task<bool> HasClass(string className);

        /// <summary>
        /// Get the HTML contents of the first element in the set of matched elements.
        /// </summary>
        /// <returns>The HTML contents of the first element in the set of matched elements.</returns>
        Task<string> Html();

        /// <summary>
        /// Get the value of a property for the first element in the set of matched elements.
        /// </summary>
        /// <typeparam name="T">The type of returned object.</typeparam>
        /// <param name="propertyName">The name of the property to get.</param>
        /// <returns>The value of a property for the first element in the set of matched elements.</returns>
        Task<T> Prop<T>(string propertyName);

        /// <summary>
        /// Remove an attribute from each element in the set of matched elements.
        /// </summary>
        /// <param name="attributeName">An attribute to remove, it can be a space-separated list of attributes.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> RemoveAttr(string attributeName);

        /// <summary>
        /// Remove a single class or multiple classes from each element in the set of matched elements.
        /// </summary>
        /// <param name="className">One or more space-separated classes to be removed from the class attribute of each matched element.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> RemoveClass(string className);

        /// <summary>
        /// Remove a single class or multiple classes from each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning one or more space-separated class names to be removed. Receives the index position of the element in the set and the old class value as arguments.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> RemoveClass(Func<int, string, string> function);

        /// <summary>
        /// Remove a property for the set of matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to remove.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> RemoveProp(string propertyName);

        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the state argument.
        /// </summary>
        /// <param name="className">One or more class names (separated by spaces) to be toggled for each element in the matched set.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> ToggleClass(string className);

        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the state argument.
        /// </summary>
        /// <param name="className">One or more class names (separated by spaces) to be toggled for each element in the matched set.</param>
        /// <param name="state">A Boolean (not just truthy/falsy) value to determine whether the class should be added or removed.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> ToggleClass(string className, bool state);

        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the state argument.
        /// </summary>
        /// <param name="function">A function that returns class names to be toggled in the class attribute of each element in the matched set. Receives the index position of the element in the set, the old class value, and the state as arguments.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> ToggleClass(Func<int, string, string> function);

        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the state argument.
        /// </summary>
        /// <param name="function">A function that returns class names to be toggled in the class attribute of each element in the matched set. Receives the index position of the element in the set, the old class value, and the state as arguments.</param>
        /// <param name="state">A boolean value to determine whether the class should be added or removed.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> ToggleClass(Func<int, string, string> function, bool state);

        /// <summary>
        /// Get the current computed height for the first element in the set of matched elements.
        /// </summary>
        /// <returns>The current computed height for the first element in the set of matched elements.</returns>
        Task<double> Height();

        /// <summary>
        /// Set the CSS height of every matched element.
        /// </summary>
        /// <param name="value">An integer representing the number of pixels, or an integer with an optional unit of measure appended (as a string).</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Height(double value);

        /// <summary>
        /// Set the CSS height of every matched element.
        /// </summary>
        /// <param name="function">A function returning the height to set. Receives the index position of the element in the set and the old height as arguments.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Height(Func<int, int, string> function);

        /// <summary>
        /// Set the CSS height of every matched element.
        /// </summary>
        /// <param name="function">A function returning the height to set. Receives the index position of the element in the set and the old height as arguments.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Height(Func<int, int, double> function);

        /// <summary>
        /// Get the current computed height for the first element in the set of matched elements, including padding but not border.
        /// </summary>
        /// <returns>The current computed height for the first element in the set of matched elements, including padding but not border.</returns>
        Task<double> InnerHeight();

        /// <summary>
        /// Set the CSS inner height of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A number representing the number of pixels.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> InnerHeight(double value);

        /// <summary>
        /// Set the CSS inner height of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A number along with an optional unit of measure appended (as a string).</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> InnerHeight(string value);

        /// <summary>
        /// Set the CSS inner height of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the inner height (including padding but not border) to set. Receives the index position of the element in the set and the old inner height as arguments.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> InnerHeight(Func<int, double, string> function);

        /// <summary>
        /// Set the CSS inner height of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the inner height (including padding but not border) to set. Receives the index position of the element in the set and the old inner height as arguments.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> InnerHeight(Func<int, double, double> function);

        /// <summary>
        /// Get the current computed width for the first element in the set of matched elements.
        /// </summary>
        /// <returns>The current computed width for the first element in the set of matched elements.</returns>
        Task<double> Width();

        /// <summary>
        /// Set the CSS width of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">An integer representing the number of pixels.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Width(double value);

        /// <summary>
        /// Set the CSS inner width of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A number along with an optional unit of measure appended (as a string).</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Width(string value);

        /// <summary>
        /// Set the CSS width of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the width to set. Receives the index position of the element in the set and the old width as arguments.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Width(Func<int, int, string> function);

        /// <summary>
        /// Set the CSS width of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the width to set. Receives the index position of the element in the set and the old width as arguments.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Width(Func<int, int, double> function);

        /// <summary>
        /// Get the current computed inner width for the first element in the set of matched elements, including padding but not border.
        /// </summary>
        /// <returns>The current computed inner width for the first element in the set of matched elements, including padding but not border.</returns>
        Task<double> InnerWidth();

        /// <summary>
        /// Set the CSS inner width of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A number representing the number of pixels.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> InnerWidth(double value);

        /// <summary>
        /// Set the CSS inner width of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A number along with an optional unit of measure appended (as a string).</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> InnerWidth(string value);

        /// <summary>
        /// Set the CSS inner width of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the inner width (including padding but not border) to set. Receives the index position of the element in the set and the old inner width as arguments.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> InnerWidth(Func<int, double, string> function);

        /// <summary>
        /// Set the CSS inner width of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the inner width (including padding but not border) to set. Receives the index position of the element in the set and the old inner width as arguments.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> InnerWidth(Func<int, double, double> function);

        /// <summary>
        /// Get the current coordinates of the first element in the set of matched elements, relative to the document.
        /// </summary>
        /// <returns>The current coordinates of the first element in the set of matched elements, relative to the document.</returns>
        Task<Coordinate> Offset();

        /// <summary>
        /// Set the current coordinates of every element in the set of matched elements, relative to the document.
        /// </summary>
        /// <param name="coordinates">An object containing the properties top and left, which are numbers indicating the new top and left coordinates for the elements.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Offset(Coordinate coordinates);

        /// <summary>
        /// Set the current coordinates of every element in the set of matched elements, relative to the document.
        /// </summary>
        /// <param name="function">A function to return the coordinates to set. Receives the index of the element in the collection as the first argument and the current coordinates as the second argument. The function should return an object with the new top and left properties.</param>
        /// <returns>DOM object.</returns>
        Task<IAsyncDom> Offset(Func<int, Coordinate, Coordinate> function);

        /// <summary>
        /// Convert async Dom to sync Dom.
        /// </summary>
        /// <returns>Sync Dom</returns>
        [Obsolete("ToSync is deprecated as it always creates a new sync Dom. Use AsSync instead.")]
        ISyncDom ToSync();

        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <returns></returns>
        Task<IAsyncDom> Off();

        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="event">One or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        /// <returns></returns>
        Task<IAsyncDom> Off(string @event);

        /// <summary>
        /// Get the current computed outer height (including padding, border, and optionally margin) for the first element in the set of matched elements.
        /// </summary>
        /// <param name="includeMargin">A Boolean indicating whether to include the element's margin in the calculation.</param>
        /// <returns></returns>
        Task<double> OuterHeight(bool includeMargin = false);

        /// <summary>
        /// Set the CSS outer height of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A number representing the number of pixels, or a number along with an optional unit of measure appended (as a string).</param>
        /// <returns></returns>
        Task<IAsyncDom> OuterHeight(double value);

        /// <summary>
        /// Set the CSS outer height of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A number representing the number of pixels, or a number along with an optional unit of measure appended (as a string).</param>
        /// <returns></returns>
        Task<IAsyncDom> OuterHeight(string value);

        /// <summary>
        /// Set the CSS outer height of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the outer height to set. Receives the index position of the element in the set and the old outer height as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        Task<IAsyncDom> OuterHeight(Func<int, double, string> function);

        /// <summary>
        /// Set the CSS outer height of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the outer height to set. Receives the index position of the element in the set and the old outer height as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        Task<IAsyncDom> OuterHeight(Func<int, double, double> function);

        /// <summary>
        /// Get the current computed outer width (including padding, border, and optionally margin) for the first element in the set of matched elements.
        /// </summary>
        /// <param name="includeMargin">A Boolean indicating whether to include the element's margin in the calculation.</param>
        /// <returns></returns>
        Task<double> OuterWidth(bool includeMargin = false);

        /// <summary>
        /// Set the CSS outer width of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A number representing the number of pixels, or a number along with an optional unit of measure appended (as a string).</param>
        /// <returns></returns>
        Task<IAsyncDom> OuterWidth(double value);

        /// <summary>
        /// Set the CSS outer width of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A number representing the number of pixels, or a number along with an optional unit of measure appended (as a string).</param>
        /// <returns></returns>
        Task<IAsyncDom> OuterWidth(string value);

        /// <summary>
        /// Set the CSS outer width of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the outer width to set. Receives the index position of the element in the set and the old outer width as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        Task<IAsyncDom> OuterWidth(Func<int, double, string> function);

        /// <summary>
        /// Set the CSS outer width of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the outer width to set. Receives the index position of the element in the set and the old outer width as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        Task<IAsyncDom> OuterWidth(Func<int, double, double> function);

        /// <summary>
        /// Get the current coordinates of the first element in the set of matched elements, relative to the offset parent.
        /// </summary>
        /// <returns></returns>
        Task<Coordinate> Position();

        /// <summary>
        /// Get the current horizontal position of the scroll bar for the first element in the set of matched elements.
        /// </summary>
        /// <returns></returns>
        Task<int> ScrollLeft();

        /// <summary>
        /// Set the current horizontal position of the scroll bar for each of the set of matched elements.
        /// </summary>
        /// <param name="value">An integer indicating the new position to set the scroll bar to.</param>
        /// <returns></returns>
        Task<IAsyncDom> ScrollLeft(double value);

        /// <summary>
        /// Get the current vertical position of the scroll bar for the first element in the set of matched elements or set the vertical position of the scroll bar for every matched element.
        /// </summary>
        /// <returns></returns>
        Task<double> ScrollTop();

        /// <summary>
        /// Set the current vertical position of the scroll bar for each of the set of matched elements.
        /// </summary>
        /// <param name="value">A number indicating the new position to set the scroll bar to.</param>
        /// <returns></returns>
        Task<IAsyncDom> ScrollTop(double value);

        /// <summary>
        /// Get sync Dom from async Dom. The returned object is singleton. AsSync won't re-initialize Dom once this async Dom has been converted before by AsSync() or Dom's AsAsync() has been called.
        /// </summary>
        /// <returns></returns>
        ISyncDom AsSync();
    }
}