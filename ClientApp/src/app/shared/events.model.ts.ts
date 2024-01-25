import {Participant} from "./participants.model.ts";

export class Eveniment {
  id: number = 0
  eventName: string = ""
  place: string = ""
  participants : Participant[] = []
}
