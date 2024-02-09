"use client"
import React from 'react'
import { Card, CardContent } from "@/components/ui/card"
import {
  Carousel,
  CarouselContent,
  CarouselItem,
  CarouselNext,
  CarouselPrevious,
} from "@/components/ui/carousel"
import Autoplay from "embla-carousel-autoplay"

export default function page() {

  const plugin = React.useRef(
    Autoplay({ delay: 2000, stopOnInteraction: true })
  )

  return (
    <div className='w-screen h-screen bg-cblack'>
    <div>
      <nav className='bg-cgreenm flex justify-between py-6'>
        <ul className='flex'>
          <li>
            <a href="/home" className='font-bold ml-5 text-cwhite'>TournifyApp</a>
          </li>
          
        </ul>
        <ul className='text-cwhite font-bold'>
          <li>
            <a className='mr-8' >@TheMandalorian</a>
          </li>
        </ul>
      </nav>
    </div>
    <div className='overflow-hidden '>
    <Carousel
      plugins={[plugin.current]}
      className="w-full h-72 ml-1"
      onMouseEnter={plugin.current.stop}
      onMouseLeave={plugin.current.reset}
    >
      <CarouselContent className='h-72 w-full border-b-gray-700 '>
        {Array.from({ length: 5 }).map((_, index) => (
          <CarouselItem key={index} className='h-48 w-full'>
            <div >
              <Card className='h-72 w-full'>
                <CardContent className="flex w-full h-72 aspect-square items-center justify-center bg-pink-400">
                  <span className="text-4xl font-semibold text-black">{index + 1}</span>
                </CardContent>
              </Card>
            </div>
          </CarouselItem>
        ))}
      </CarouselContent>
      <CarouselPrevious />
      <CarouselNext />
    </Carousel>
    </div>
    </div>
  )
}
