import * as React from "react"

type LinkProps = {
    href: string;
    targetBlank: boolean;
    childrne: React.ReactNode | string;
}

export default function Link({href, targetBlank, children}: any) {
    return ( 
        <a
          className="App-link"
          href={href}
          target={targetBlank ? '_blank' : ''}
          rel={targetBlank ? 'noopener noreferer' : ''}
        >
          {children}
        </a>
    )
}