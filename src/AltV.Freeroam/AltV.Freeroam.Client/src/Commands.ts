import { onServer, log, Vector3 } from 'alt-client';

// alt:V Events
onServer("Command:Pos:Print", (pos: Vector3): void => {
    log('X: ' + pos.x + ' Y: ' + pos.y + ' Z: ' + pos.z);
});

onServer("Command:Rot:Print", (rot: Vector3): void => {
    log('Roll: ' + rot.x + ' Pitch: ' + rot.y + ' Yaw: ' + rot.z);
});