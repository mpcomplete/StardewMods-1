using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pathoschild.LookupAnything.Framework.Fields
{
    /// <summary>A metadata field shown as an extended property in the encyclopedia.</summary>
    public interface ICustomField
    {
        /*********
        ** Accessors
        *********/
        /// <summary>A short field label.</summary>
        string Label { get; }

        /// <summary>The field value.</summary>
        string Value { get; }

        /// <summary>Whether the field should be displayed.</summary>
        bool HasValue { get; }


        /*********
        ** Public methods
        *********/
        /// <summary>Draw the value (or return <c>null</c> to render the <see cref="Value"/> using the default format).</summary>
        /// <param name="sprites">The sprite batch in which to draw.</param>
        /// <param name="font">The recommended font.</param>
        /// <param name="position">The position at which to draw.</param>
        /// <param name="wrapWidth">The maximum width before which content should be wrapped..</param>
        /// <returns>Returns the drawn dimensions, or <c>null</c> to draw the <see cref="Value"/> using the default format.</returns>
        Vector2? DrawValue(SpriteBatch sprites, SpriteFont font, Vector2 position, float wrapWidth);
    }
}