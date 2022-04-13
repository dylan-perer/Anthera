import * as React from "react"
import Svg, { Defs, RadialGradient, Stop, Circle } from "react-native-svg"

const SvgComponent = (props) => (
  <Svg
    xmlns="http://www.w3.org/2000/svg"
    width={281.691}
    height={281.691}
    viewBox="0 0 281.691 281.691"
    {...props}
  >
    <Defs>
      <RadialGradient
        id="a"
        cx={0.751}
        cy={0.349}
        r={0.763}
        gradientTransform="rotate(82.255 .751 .35)"
        gradientUnits="objectBoundingBox"
      >
        <Stop offset={0} stopColor="#2170fc" />
        <Stop offset={1} stopColor="#d185fc" />
      </RadialGradient>
    </Defs>
    <Circle
      cx={115}
      cy={115}
      r={115}
      transform="rotate(-74.99 144.788 111.064)"
      fill="url(#a)"
    />
  </Svg>
)

export default SvgComponent
